namespace DevPF.Views
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Label();
            this.Bar_Progress = new DevExpress.XtraEditors.PictureEdit();
            this.CE_YHMM = new DevExpress.XtraEditors.CheckEdit();
            this.CE_YHZH = new DevExpress.XtraEditors.CheckEdit();
            this.txt_YHMM = new DevExpress.XtraEditors.TextEdit();
            this.cbox_YHZH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Label_Tile = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Progress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_YHMM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_YHZH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YHMM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_YHZH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(717, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "记住密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(596, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "记住账号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(568, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "密    码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(569, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "用户名";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(941, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 38);
            this.btnExit.TabIndex = 64;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.Location = new System.Drawing.Point(887, 156);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(69, 65);
            this.btnRegister.TabIndex = 63;
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.BtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogin.Image")));
            this.BtnLogin.Location = new System.Drawing.Point(810, 156);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(71, 65);
            this.BtnLogin.TabIndex = 62;
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Bar_Progress
            // 
            this.Bar_Progress.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bar_Progress.EditValue = ((object)(resources.GetObject("Bar_Progress.EditValue")));
            this.Bar_Progress.Location = new System.Drawing.Point(643, 228);
            this.Bar_Progress.Name = "Bar_Progress";
            this.Bar_Progress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Bar_Progress.Properties.ZoomAccelerationFactor = 1D;
            this.Bar_Progress.Size = new System.Drawing.Size(155, 15);
            this.Bar_Progress.TabIndex = 61;
            this.Bar_Progress.Visible = false;
            // 
            // CE_YHMM
            // 
            this.CE_YHMM.Location = new System.Drawing.Point(694, 248);
            this.CE_YHMM.Name = "CE_YHMM";
            this.CE_YHMM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE_YHMM.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.CE_YHMM.Properties.Appearance.Options.UseFont = true;
            this.CE_YHMM.Properties.Appearance.Options.UseForeColor = true;
            this.CE_YHMM.Properties.Caption = "";
            this.CE_YHMM.Size = new System.Drawing.Size(122, 19);
            this.CE_YHMM.TabIndex = 57;
            this.CE_YHMM.CheckedChanged += new System.EventHandler(this.CE_YHMM_CheckedChanged);
            // 
            // CE_YHZH
            // 
            this.CE_YHZH.Location = new System.Drawing.Point(572, 248);
            this.CE_YHZH.Name = "CE_YHZH";
            this.CE_YHZH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE_YHZH.Properties.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.CE_YHZH.Properties.Appearance.Options.UseFont = true;
            this.CE_YHZH.Properties.Appearance.Options.UseForeColor = true;
            this.CE_YHZH.Properties.Caption = "";
            this.CE_YHZH.Size = new System.Drawing.Size(122, 19);
            this.CE_YHZH.TabIndex = 56;
            this.CE_YHZH.CheckedChanged += new System.EventHandler(this.CE_YHZH_CheckedChanged);
            // 
            // txt_YHMM
            // 
            this.txt_YHMM.EditValue = "admin888";
            this.txt_YHMM.Location = new System.Drawing.Point(643, 198);
            this.txt_YHMM.Name = "txt_YHMM";
            this.txt_YHMM.Properties.MaxLength = 20;
            this.txt_YHMM.Properties.PasswordChar = '*';
            this.txt_YHMM.Size = new System.Drawing.Size(155, 20);
            this.txt_YHMM.TabIndex = 53;
            // 
            // cbox_YHZH
            // 
            this.cbox_YHZH.EditValue = "admin";
            this.cbox_YHZH.Location = new System.Drawing.Point(643, 161);
            this.cbox_YHZH.Name = "cbox_YHZH";
            this.cbox_YHZH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_YHZH.Properties.MaxLength = 20;
            this.cbox_YHZH.Size = new System.Drawing.Size(155, 20);
            this.cbox_YHZH.TabIndex = 52;
            this.cbox_YHZH.SelectedIndexChanged += new System.EventHandler(this.cbox_YHZH_SelectedIndexChanged);
            // 
            // Label_Tile
            // 
            this.Label_Tile.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Tile.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_Tile.Appearance.Options.UseFont = true;
            this.Label_Tile.Appearance.Options.UseForeColor = true;
            this.Label_Tile.Location = new System.Drawing.Point(246, 35);
            this.Label_Tile.Name = "Label_Tile";
            this.Label_Tile.Size = new System.Drawing.Size(570, 42);
            this.Label_Tile.TabIndex = 51;
            this.Label_Tile.Text = "地下综合管线可视化管理信息系统";
            this.Label_Tile.Visible = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DevPF.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(996, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.Bar_Progress);
            this.Controls.Add(this.CE_YHMM);
            this.Controls.Add(this.CE_YHZH);
            this.Controls.Add(this.txt_YHMM);
            this.Controls.Add(this.cbox_YHZH);
            this.Controls.Add(this.Label_Tile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆 ";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bar_Progress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_YHMM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CE_YHZH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_YHMM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_YHZH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label btnRegister;
        private System.Windows.Forms.Label BtnLogin;
        private DevExpress.XtraEditors.PictureEdit Bar_Progress;
        private DevExpress.XtraEditors.CheckEdit CE_YHMM;
        private DevExpress.XtraEditors.CheckEdit CE_YHZH;
        private DevExpress.XtraEditors.TextEdit txt_YHMM;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_YHZH;
        private DevExpress.XtraEditors.LabelControl Label_Tile;
    }
}