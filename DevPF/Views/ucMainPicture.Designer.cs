namespace DevPF.Views
{
    partial class ucMainPicture
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tileControl = new DevExpress.XtraEditors.TileControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.peCurrentImage = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peCurrentImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tileControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 338);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(617, 134);
            this.panelControl1.TabIndex = 0;
            // 
            // tileControl
            // 
            this.tileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl.Location = new System.Drawing.Point(2, 2);
            this.tileControl.Name = "tileControl";
            this.tileControl.Size = new System.Drawing.Size(613, 130);
            this.tileControl.TabIndex = 0;
            this.tileControl.Text = "tileControl1";
            this.tileControl.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.OnTileControlItemClick);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.peCurrentImage);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(617, 338);
            this.panelControl2.TabIndex = 1;
            // 
            // peCurrentImage
            // 
            this.peCurrentImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peCurrentImage.Location = new System.Drawing.Point(2, 2);
            this.peCurrentImage.Name = "peCurrentImage";
            this.peCurrentImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCurrentImage.Size = new System.Drawing.Size(613, 334);
            this.peCurrentImage.TabIndex = 0;
            // 
            // ucMainPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucMainPicture";
            this.Size = new System.Drawing.Size(617, 472);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peCurrentImage.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TileControl tileControl;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit peCurrentImage;

    }
}
