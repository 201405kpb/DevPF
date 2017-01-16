using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevPF.Utils;

namespace DevPF.Views
{
    public partial class ucMainChart : DevExpress.XtraEditors.XtraUserControl
    {
        private CHCNetSDK.VOICEDATACALLBACKV30 _Voicedatacallbackv30;
        public ucMainChart()
        {
            InitializeComponent();

            InitData();
        }

        private void InitData()
        {
            //表结构

            DataTable newdtb = new DataTable();
            newdtb.Columns.Add("Id", typeof(int));
            newdtb.Columns.Add("ProName", typeof(string));
            newdtb.Columns.Add("ProPrice", typeof(decimal));
            newdtb.Columns.Add("Trade_Date", typeof(string));
            newdtb.Columns["Id"].AutoIncrement = true;

            //表记录

            Random ran = new Random();
            for (int i = 1; i < 10; i++)
            {

                int RandKey = ran.Next(10, 9999);//10~9999之间的数
                decimal dBase = Convert.ToDecimal(ran.NextDouble());//0~1之间的任意数
                DataRow newRow = newdtb.NewRow();
                newRow["Trade_Date"] = i.ToString() + "月";
                newRow["ProPrice"] = Convert.ToDecimal((RandKey * dBase).ToString("0.0#"));
                newdtb.Rows.Add(newRow);
            }
            this.chartControl1.Series.Clear();



            //新建Series
            Series sr = new Series("声音监控", ViewType.Line);//名称与图标的类型

            //设置Series样式
            sr.ArgumentScaleType = ScaleType.Qualitative;//定性的

            sr.ValueScaleType = ScaleType.Numerical;//数字类型

            sr.PointOptions.PointView = PointView.ArgumentAndValues;//显示表示的信息和数据

            sr.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;//用百分比表示

            sr.PointOptions.ValueNumericOptions.Precision = 0;//百分号前面的数字不跟小数点

            //绑定数据源
            sr.DataSource = newdtb.DefaultView;//newdtb是获取到的数据(可以是数据库中的表，也可以是DataTable)

            sr.ArgumentDataMember = "Trade_Date";//绑定的文字信息（名称）(坐标横轴)

            sr.ValueDataMembers[0] = "ProPrice";//绑定的值（数据）(坐标纵轴)

            //样式
            sr.View.Color = Color.Red;//颜色

            //添加到统计图上
            this.chartControl1.Series.Add(sr);

            //图例设置
            SimpleDiagram3D diagram = new SimpleDiagram3D();

            diagram.RuntimeRotation = true;

            diagram.RuntimeScrolling = true;

            diagram.RuntimeZooming = true;
            //设置图表标题
            ChartTitle ct = new ChartTitle();

            ct.Text = "声音曲线图";

            ct.TextColor = Color.Black;//颜色

            ct.Font = new Font("Tahoma", 12);//字体

            ct.Dock = ChartTitleDockStyle.Top;//停靠在上方

            ct.Alignment = StringAlignment.Center;//居中显示

            this.chartControl1.Titles.Add(ct);

            chartControl1.Legend.Visible = true;//不现实指示图
        }
        private void VOICEDATACALLBACKV30(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser)
        {
        }

        public void Open_Click(object sender, EventArgs e)
        {
            ucMainVideo video = new ucMainVideo();
            _Voicedatacallbackv30 = VOICEDATACALLBACKV30;
            IntPtr pUser = new IntPtr();//用户数据
            CHCNetSDK.NET_DVR_StartVoiceCom_MR_V30(video.m_lUserID,(uint) 1, _Voicedatacallbackv30, pUser);

        }

    }
}
