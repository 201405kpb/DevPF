using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevPF.Model;
using DevPF.Utils;
using WMPLib;

namespace DevPF.Views{
    public partial class ucMainVideo : DevExpress.XtraEditors.XtraUserControl
    {
        private int userid;
        public Int32 m_lUserID = -1;
        private Int32 m_lRealHandle = -1;
        private Int32 handle = -1;
        private uint iLastErr = 0;
        private string str;
        public ucMainVideo()
		{
			this.InitializeComponent();
			this.userid = 0;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			ResultClass<int> resultClass = CommonMethods.VideoLogionInfo(this.txtUserName.Text, this.txtPassWord.Text, this.txtIp.Text, this.txtPort.Text, 1);
			if (resultClass.Result)
			{
				this.userid = resultClass.ResultInfo;
                if (m_lUserID<0)
                {
                    CHCNetSDK.NET_DVR_Init();
                    string DVRIPAddress = txtIp.Text; //设备IP地址或者域名
                    Int16 DVRPortNumber = Int16.Parse(txtPort.Text);//设备服务端口号
                    string DVRUserName = txtUserName.Text;//设备登录用户名
                    string DVRPassword = txtPassWord.Text;//设备登录密码

                    CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                    //登录设备 Login the device
                    m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                    if (m_lUserID < 0)
                    {
                        iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                        str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //登录失败，输出错误号
                        MessageBox.Show(str);
                        return;
                    }
                    else
                    {
                        //登录成功
                        XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btnLogin.Text = "退出";
                    }

                }
                
			}
			else
			{
                XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnPrew_Click(object sender, EventArgs e)
		{
            ResultClass<string> resultClass = CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.PREVIEW);
            if (!resultClass.Result)
            {
                XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
                
            if (userid < 0)
            {
                XtraMessageBox.Show("请先登录！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (m_lRealHandle < 0)
            {
                CHCNetSDK.NET_DVR_Init();
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = RealPlayWnd.Handle;//预览窗口
                lpPreviewInfo.lChannel = Int16.Parse(txtZT.Text);//预te览的设备通道
                lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流
                lpPreviewInfo.dwDisplayBufNum = 15; //播放库播放缓冲区最大缓冲帧数

                CHCNetSDK.REALDATACALLBACK RealData = new CHCNetSDK.REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数
                IntPtr pUser = new IntPtr();//用户数据
                //打开预览 Start live view 
                m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);
                if (m_lRealHandle < 0)
                {
                    uint iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    string str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //预览失败，输出错误号
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    //预览成功
                    btnPrew.Text = "停止预览";
                }
            }
            else
            {
                //停止预览 Stop live view 
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
                {
                   uint iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                   string  str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                m_lRealHandle = -1;
                btnPrew.Text = "预览";

            }
		}
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
        }

		private void btnbmp_Click(object sender, EventArgs e)
		{
			ResultClass<string> resultClass = CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.CAPTUREJPG);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void btnjpeg_Click(object sender, EventArgs e)
		{
			ResultClass<string> resultClass = CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.CAPTUREJPG);
            XtraMessageBox.Show(resultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

        private bool bAuto = false;
		private void btnclient_Click(object sender, EventArgs e)
		{
			
            if (!bAuto)
            {
                CommonMethods.PreviewInfo(this.userid, 0, 1, 0, VideoEnum.RECORD);
                btnclient.Text = "停止录像";
                bAuto = true;
            }
            else
            {
                CommonMethods.PreviewInfo(this.userid, 0, 1,1, VideoEnum.RECORD);
                btnclient.Text = "开始录像";
                bAuto = false;
            }
            
		}

        private void btnyun_Click(object sender, EventArgs e)
        {
            FrmPTZControl frmPtzControl = new FrmPTZControl(this.userid);
            frmPtzControl.ShowDialog();
        }

    }
}
