using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevPF.Model
{
    /// <summary>
    ///  登录窗体设置类
    /// </summary>
    public class LoginFormApi
    {
        /// <summary>
        /// 初始化方法
        /// </summary>
        public LoginFormApi()
        { }
        #region 声明API函数
        //用于设置窗体启动样式
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        private const int AW_HOR_POSITIVE = 0x0001;       //从左向右显示
        private const int AW_HOR_NEGATIVE = 0x0002;       //从右向左显示
        private const int AW_VER_POSITIVE = 0x0004;       //从上到下显示
        private const int AW_VER_NEGATIVE = 0x0008;       //从下到上显示
        private const int AW_CENTER = 0x0010;             //从中间向四周
        private const int AW_BLEND = 0x80000;             //透明渐变显示效果
        private const int AW_ACTIVATE = 0x20000;          //普通显示
        private const int AW_HIDE = 0x10000;              //其他功能中要用到，下面有例子
        private const int AW_SLIDE = 0x40000;             //其他功能中要用到，下面有例子
        //声明API函数，用于拖动窗体
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();         //用来为当前的应用程序释放鼠标捕获

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam); //用来调用一个窗口的窗口函数，并将一个信息发送给那个窗口
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;
        private const int HTCAPTION = 0x0002;

        #endregion

        #region 设置窗体启动样式
        /// <summary>
        /// 设置窗体启动样式
        /// </summary>
        /// <param name="ln_Index">样式编号</param>
        /// <param name="li_Handle">所要操作的窗体的句柄</param>
        public void SetWindows(int ln_Index, IntPtr li_Handle)
        {
            switch (ln_Index)
            {
                case 1:
                    AnimateWindow(li_Handle, 300, AW_HOR_POSITIVE);                                    //从左向右显示
                    break;
                case 2:
                    AnimateWindow(li_Handle, 300, AW_HOR_NEGATIVE);                                    //从右向左显示
                    break;
                case 3:
                    AnimateWindow(li_Handle, 300, AW_VER_POSITIVE);                                    //从上到下显示
                    break;
                case 4:
                    AnimateWindow(li_Handle, 300, AW_VER_NEGATIVE);                                    //从下到上显示
                    break;
                case 5:
                    AnimateWindow(li_Handle, 300, AW_BLEND);                                           //透明渐变显示
                    break;
                case 6:
                    AnimateWindow(li_Handle, 300, AW_CENTER);                                          //从中间向四周
                    break;
                case 7:
                    AnimateWindow(li_Handle, 300, AW_CENTER | AW_ACTIVATE);                            //动画由小渐大,现在取消
                    break;
                case 8:
                    AnimateWindow(li_Handle, 300, AW_SLIDE | AW_HOR_POSITIVE | AW_VER_POSITIVE);       //左上角伸展
                    break;
                case 9:
                    AnimateWindow(li_Handle, 300, AW_SLIDE | AW_HOR_POSITIVE | AW_VER_NEGATIVE);       //左下角伸展
                    break;
                case 10:
                    AnimateWindow(li_Handle, 300, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_POSITIVE);       //右上角伸展
                    break;
                case 11:
                    AnimateWindow(li_Handle, 300, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_NEGATIVE);　　　 //右下角伸展
                    break;
                default:
                    AnimateWindow(li_Handle, 300, AW_ACTIVATE);                                        //普通显示
                    break;
            }
        }
        #endregion

        #region 设置窗体启动样式
        /// <summary>
        /// 设置窗体启动样式
        /// </summary>
        /// <param name="ln_Index">样式编号</param>
        /// <param name="ln_Time">设置窗体的加载时间</param>
        /// <param name="li_Handle">所要操作的窗体的句柄</param>
        public void SetWindows(int ln_Index, Int32 ln_Time, IntPtr li_Handle)
        {
            switch (ln_Index)
            {
                case 1:
                    AnimateWindow(li_Handle, ln_Time, AW_HOR_POSITIVE);                                    //从左向右显示
                    break;
                case 2:
                    AnimateWindow(li_Handle, ln_Time, AW_HOR_NEGATIVE);                                    //从右向左显示
                    break;
                case 3:
                    AnimateWindow(li_Handle, ln_Time, AW_VER_POSITIVE);                                    //从上到下显示
                    break;
                case 4:
                    AnimateWindow(li_Handle, ln_Time, AW_VER_NEGATIVE);                                    //从下到上显示
                    break;
                case 5:
                    AnimateWindow(li_Handle, ln_Time, AW_BLEND);                                           //透明渐变显示
                    break;
                case 6:
                    AnimateWindow(li_Handle, ln_Time, AW_CENTER);                                          //从中间向四周
                    break;
                case 7:
                    AnimateWindow(li_Handle, ln_Time, AW_CENTER | AW_ACTIVATE);                            //动画由小渐大,现在取消
                    break;
                case 8:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_POSITIVE | AW_VER_POSITIVE);       //左上角伸展
                    break;
                case 9:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_POSITIVE | AW_VER_NEGATIVE);       //左下角伸展
                    break;
                case 10:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_POSITIVE);       //右上角伸展
                    break;
                case 11:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_NEGATIVE);　　　 //右下角伸展
                    break;
                default:
                    AnimateWindow(li_Handle, ln_Time, AW_ACTIVATE);                                        //普通显示
                    break;
            }
        }
        #endregion

        #region 设置窗体退出样式
        /// <summary>
        /// 设置窗体退出样式
        /// </summary>
        /// <param name="ln_Index">样式编号</param>
        /// <param name="ln_Time">设置窗体的退出时间</param>
        /// <param name="li_Handle">所要操作的窗体的句柄</param>
        public void SetExitWindows(int ln_Index, Int32 ln_Time, IntPtr li_Handle)
        {
            switch (ln_Index)
            {
                case 1:
                    AnimateWindow(li_Handle, ln_Time, AW_HOR_POSITIVE | AW_HIDE);                                    //从左向右显示
                    break;
                case 2:
                    AnimateWindow(li_Handle, ln_Time, AW_HOR_NEGATIVE | AW_HIDE);                                    //从右向左显示
                    break;
                case 3:
                    AnimateWindow(li_Handle, ln_Time, AW_VER_POSITIVE | AW_HIDE);                                    //从上到下显示
                    break;
                case 4:
                    AnimateWindow(li_Handle, ln_Time, AW_VER_NEGATIVE | AW_HIDE);                                    //从下到上显示
                    break;
                case 5:
                    AnimateWindow(li_Handle, ln_Time, AW_BLEND | AW_HIDE);                                           //透明渐变显示
                    break;
                case 6:
                    AnimateWindow(li_Handle, ln_Time, AW_CENTER | AW_HIDE);                                          //从中间向四周
                    break;
                case 7:
                    AnimateWindow(li_Handle, ln_Time, AW_CENTER | AW_ACTIVATE | AW_HIDE);                            //动画由小渐大,现在取消
                    break;
                case 8:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_POSITIVE | AW_VER_POSITIVE | AW_HIDE);       //左上角伸展
                    break;
                case 9:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_POSITIVE | AW_VER_NEGATIVE | AW_HIDE);       //左下角伸展
                    break;
                case 10:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_POSITIVE | AW_HIDE);       //右上角伸展
                    break;
                case 11:
                    AnimateWindow(li_Handle, ln_Time, AW_SLIDE | AW_HOR_NEGATIVE | AW_VER_NEGATIVE | AW_HIDE);　　　 //右下角伸展
                    break;
                default:
                    AnimateWindow(li_Handle, ln_Time, AW_ACTIVATE | AW_HIDE);                                        //普通显示
                    break;
            }
        }
        #endregion

        #region 移动窗体
        /// <summary>
        /// 移动窗体
        /// </summary>
        /// <param name="li_Handle">要移动窗体的handle</param>
        public void MoveWindowns(IntPtr li_Handle)
        {
            ReleaseCapture();
            SendMessage(li_Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region 设置窗体加载的图片
        /// <summary>
        /// 设置窗体加载的图片
        /// </summary>
        /// <param name="lc_Form">要设置的Form窗体</param>
        /// <param name="ls_Picture">窗体背景图片的路径</param>
        /// <param name="ls_FormPictuer">窗体图标的路径</param>
        /// <returns></returns>
        public bool SetWindowsImage(Form lc_Form, string ls_Picture, string ls_FormPictuer)
        {
            try
            {
                lc_Form.Icon = new Icon(ls_FormPictuer);
                Image backImage = Image.FromFile(ls_Picture);
                lc_Form.Width = backImage.Width;
                lc_Form.Height = backImage.Height;
                lc_Form.BackgroundImage = backImage;
                lc_Form.BackgroundImageLayout = ImageLayout.Stretch;
                lc_Form.FormBorderStyle = FormBorderStyle.None;
                lc_Form.StartPosition = FormStartPosition.CenterScreen;
                return true;
            }
            catch
            {
                XtraMessageBox.Show("请确定登录图片路径是否正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        #endregion

     
    }
    
}
