using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevPF.Views
{
    partial class ucMainVideo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private LayoutControl layoutControl1;

        private LayoutControlGroup layoutControlGroup1;

        private SimpleButton btnLogin;

        private TextEdit txtIp;

        private TextEdit txtPort;

        private TextEdit txtUserName;

        private TextEdit txtPassWord;

        private LayoutControlItem layoutControlItem1;

        private LayoutControlItem layoutControlItem2;

        private LayoutControlItem layoutControlItem4;

        private LayoutControlItem layoutControlItem5;

        private LayoutControlItem layoutControlItem7;

        private PanelControl panelControl1;

        private TextEdit txtZT;

        private LayoutControlItem layoutControlItem3;

        private LayoutControlItem layoutControlItem6;

        private SimpleButton btnbmp;

        private SimpleButton btnPrew;

        private SimpleButton btnyun;

        private SimpleButton btnclient;

        private SimpleButton btnjpeg;

        private LayoutControlItem layoutControlItem13;

        private LayoutControlItem layoutControlItem14;

        private LayoutControlItem layoutControlItem15;

        private LayoutControlItem layoutControlItem10;

        private LayoutControlItem layoutControlItem11;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnbmp = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrew = new DevExpress.XtraEditors.SimpleButton();
            this.btnyun = new DevExpress.XtraEditors.SimpleButton();
            this.btnclient = new DevExpress.XtraEditors.SimpleButton();
            this.btnjpeg = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtIp = new DevExpress.XtraEditors.TextEdit();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassWord = new DevExpress.XtraEditors.TextEdit();
            this.txtZT = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnbmp);
            this.layoutControl1.Controls.Add(this.btnPrew);
            this.layoutControl1.Controls.Add(this.btnyun);
            this.layoutControl1.Controls.Add(this.btnclient);
            this.layoutControl1.Controls.Add(this.btnjpeg);
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.btnLogin);
            this.layoutControl1.Controls.Add(this.txtIp);
            this.layoutControl1.Controls.Add(this.txtPort);
            this.layoutControl1.Controls.Add(this.txtUserName);
            this.layoutControl1.Controls.Add(this.txtPassWord);
            this.layoutControl1.Controls.Add(this.txtZT);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1092, 264, 534, 437);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(828, 606);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnbmp
            // 
            this.btnbmp.Location = new System.Drawing.Point(535, 530);
            this.btnbmp.Name = "btnbmp";
            this.btnbmp.Size = new System.Drawing.Size(277, 27);
            this.btnbmp.StyleController = this.layoutControl1;
            this.btnbmp.TabIndex = 16;
            this.btnbmp.Text = "BMP抓图";
            this.btnbmp.Click += new System.EventHandler(this.btnbmp_Click);
            // 
            // btnPrew
            // 
            this.btnPrew.Location = new System.Drawing.Point(244, 530);
            this.btnPrew.Name = "btnPrew";
            this.btnPrew.Size = new System.Drawing.Size(285, 27);
            this.btnPrew.StyleController = this.layoutControl1;
            this.btnPrew.TabIndex = 15;
            this.btnPrew.Text = "预览";
            this.btnPrew.Click += new System.EventHandler(this.btnPrew_Click);
            // 
            // btnyun
            // 
            this.btnyun.Location = new System.Drawing.Point(535, 563);
            this.btnyun.Name = "btnyun";
            this.btnyun.Size = new System.Drawing.Size(277, 27);
            this.btnyun.StyleController = this.layoutControl1;
            this.btnyun.TabIndex = 14;
            this.btnyun.Text = "云台控制";
            this.btnyun.Click += new System.EventHandler(this.btnyun_Click);
            // 
            // btnclient
            // 
            this.btnclient.Location = new System.Drawing.Point(244, 563);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(285, 27);
            this.btnclient.StyleController = this.layoutControl1;
            this.btnclient.TabIndex = 13;
            this.btnclient.Text = "客户端录像";
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btnjpeg
            // 
            this.btnjpeg.Location = new System.Drawing.Point(16, 558);
            this.btnjpeg.Name = "btnjpeg";
            this.btnjpeg.Size = new System.Drawing.Size(222, 27);
            this.btnjpeg.StyleController = this.layoutControl1;
            this.btnjpeg.TabIndex = 12;
            this.btnjpeg.Text = "JPEG抓图";
            this.btnjpeg.Click += new System.EventHandler(this.btnjpeg_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.RealPlayWnd);
            this.panelControl1.Location = new System.Drawing.Point(16, 72);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(796, 452);
            this.panelControl1.TabIndex = 11;
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RealPlayWnd.Location = new System.Drawing.Point(2, 2);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(792, 448);
            this.RealPlayWnd.TabIndex = 5;
            this.RealPlayWnd.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(646, 16);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(166, 27);
            this.btnLogin.StyleController = this.layoutControl1;
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(115, 15);
            this.txtIp.Name = "txtIp";
            this.txtIp.Text = "10.196.99.236";
            this.txtIp.Size = new System.Drawing.Size(222, 24);
            this.txtIp.StyleController = this.layoutControl1;
            this.txtIp.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(441, 15);
            this.txtPort.Name = "txtPort";
            this.txtPort.Text = "8000";
            this.txtPort.Size = new System.Drawing.Size(200, 24);
            this.txtPort.StyleController = this.layoutControl1;
            this.txtPort.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(115, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Text = "admin";
            this.txtUserName.Size = new System.Drawing.Size(222, 24);
            this.txtUserName.StyleController = this.layoutControl1;
            this.txtUserName.TabIndex = 7;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(441, 43);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Text = "jj86138623";
            this.txtPassWord.Size = new System.Drawing.Size(200, 24);
            this.txtPassWord.StyleController = this.layoutControl1;
            this.txtPassWord.TabIndex = 8;
            // 
            // txtZT
            // 
            this.txtZT.EditValue = "1";
            this.txtZT.Location = new System.Drawing.Point(115, 529);
            this.txtZT.Name = "txtZT";
            this.txtZT.Properties.Mask.EditMask = "c0";
            this.txtZT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtZT.Size = new System.Drawing.Size(124, 24);
            this.txtZT.StyleController = this.layoutControl1;
            this.txtZT.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(828, 606);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIp;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(326, 28);
            this.layoutControlItem1.Text = "设备Ip";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPort;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(326, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(304, 28);
            this.layoutControlItem2.Text = "设备端口号";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtUserName;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(326, 28);
            this.layoutControlItem4.Text = "用户名";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtPassWord;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(326, 28);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem5.Size = new System.Drawing.Size(304, 28);
            this.layoutControlItem5.Text = "密码";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnLogin;
            this.layoutControlItem7.Location = new System.Drawing.Point(630, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(172, 56);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.panelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(802, 458);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtZT;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 514);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(228, 28);
            this.layoutControlItem6.Text = "远程/抓图通道";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(96, 18);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnjpeg;
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 542);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(228, 38);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.btnclient;
            this.layoutControlItem14.Location = new System.Drawing.Point(228, 547);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(291, 33);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.btnyun;
            this.layoutControlItem15.Location = new System.Drawing.Point(519, 547);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(283, 33);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnPrew;
            this.layoutControlItem10.Location = new System.Drawing.Point(228, 514);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(291, 33);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnbmp;
            this.layoutControlItem11.Location = new System.Drawing.Point(519, 514);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(283, 33);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // ucMainVideo
            // 
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucMainVideo";
            this.Size = new System.Drawing.Size(828, 606);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        private PictureBox RealPlayWnd;
    }

}
