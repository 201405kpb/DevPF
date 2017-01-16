namespace DevPF
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation1 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            DevExpress.XtraBars.Ribbon.ReduceOperation reduceOperation2 = new DevExpress.XtraBars.Ribbon.ReduceOperation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.rbcMainBar = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.rbnPageFile = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnPageGroupCY = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ucMain1 = new DevPF.Views.ucMain();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rbcMainBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbcMainBar
            // 
            this.rbcMainBar.ExpandCollapseItem.Id = 0;
            this.rbcMainBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbcMainBar.ExpandCollapseItem,
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.btnClose});
            this.rbcMainBar.Location = new System.Drawing.Point(0, 0);
            this.rbcMainBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbcMainBar.MaxItemId = 6;
            this.rbcMainBar.Name = "rbcMainBar";
            this.rbcMainBar.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnPageFile});
            this.rbcMainBar.QuickToolbarItemLinks.Add(this.btnOpen);
            this.rbcMainBar.QuickToolbarItemLinks.Add(this.btnSave);
            this.rbcMainBar.QuickToolbarItemLinks.Add(this.btnSaveAs);
            this.rbcMainBar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.rbcMainBar.Size = new System.Drawing.Size(1099, 192);
            // 
            // btnOpen
            // 
            this.btnOpen.Caption = "打开";
            this.btnOpen.Glyph = global::DevPF.Properties.Resources.loadfrom_16x16;
            this.btnOpen.Id = 2;
            this.btnOpen.LargeGlyph = global::DevPF.Properties.Resources.loadfrom_32x32;
            this.btnOpen.Name = "btnOpen";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "保存";
            this.btnSave.Glyph = global::DevPF.Properties.Resources.save_16x16;
            this.btnSave.Id = 3;
            this.btnSave.LargeGlyph = global::DevPF.Properties.Resources.save_32x32;
            this.btnSave.Name = "btnSave";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Caption = "另存为";
            this.btnSaveAs.Glyph = global::DevPF.Properties.Resources.saveas_16x16;
            this.btnSaveAs.Id = 4;
            this.btnSaveAs.LargeGlyph = global::DevPF.Properties.Resources.saveas_32x32;
            this.btnSaveAs.Name = "btnSaveAs";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "关闭";
            this.btnClose.Glyph = global::DevPF.Properties.Resources.close_16x16;
            this.btnClose.Id = 5;
            this.btnClose.LargeGlyph = global::DevPF.Properties.Resources.close_32x32;
            this.btnClose.Name = "btnClose";
            // 
            // rbnPageFile
            // 
            this.rbnPageFile.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnPageGroupCY});
            this.rbnPageFile.Name = "rbnPageFile";
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation1.Group = null;
            reduceOperation1.ItemLinkIndex = 0;
            reduceOperation1.ItemLinksCount = 0;
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            reduceOperation2.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.Single;
            reduceOperation2.Group = null;
            reduceOperation2.ItemLinkIndex = 0;
            reduceOperation2.ItemLinksCount = 0;
            reduceOperation2.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.LargeButtons;
            this.rbnPageFile.ReduceOperations.Add(reduceOperation1);
            this.rbnPageFile.ReduceOperations.Add(reduceOperation2);
            this.rbnPageFile.Text = "文件";
            // 
            // rbnPageGroupCY
            // 
            this.rbnPageGroupCY.ItemLinks.Add(this.btnOpen);
            this.rbnPageGroupCY.ItemLinks.Add(this.btnClose);
            this.rbnPageGroupCY.ItemLinks.Add(this.btnSave);
            this.rbnPageGroupCY.ItemLinks.Add(this.btnSaveAs);
            this.rbnPageGroupCY.Name = "rbnPageGroupCY";
            this.rbnPageGroupCY.Text = "常用";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.accordionControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 192);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(229, 552);
            this.panelControl1.TabIndex = 1;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.accordionControl1.Location = new System.Drawing.Point(2, 2);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(225, 548);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "视频";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "录像记录";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "截图记录";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "文档";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "音频记录";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(229, 192);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(15, 552);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ucMain1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(244, 192);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(855, 552);
            this.panelControl3.TabIndex = 4;
            // 
            // ucMain1
            // 
            this.ucMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMain1.Location = new System.Drawing.Point(2, 2);
            this.ucMain1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucMain1.Name = "ucMain1";
            this.ucMain1.Size = new System.Drawing.Size(851, 548);
            this.ucMain1.TabIndex = 0;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 744);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.rbcMainBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.Ribbon = this.rbcMainBar;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rbcMainBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl rbcMainBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnPageFile;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnPageGroupCY;
        private DevExpress.XtraBars.BarButtonItem btnOpen;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnSaveAs;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private Views.ucMain ucMain1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
    }
}

