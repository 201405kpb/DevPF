using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraLayout;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

namespace DevPF.Views
{
    partial class ucMainOther
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
			this.layoutControl1 = new LayoutControl();
			this.btnEnable = new SimpleButton();
			this.txtEncoderPosition = new TextEdit();
			this.txtRelativeDisplacement = new TextEdit();
			this.txtAbsolutePosition = new TextEdit();
			this.btnFBK = new SimpleButton();
			this.btnExpectedSpeedSearch = new SimpleButton();
			this.btntxtRelativeDisplacementSearch = new SimpleButton();
			this.btnAbsolutePositionSearch = new SimpleButton();
			this.btnEncoderPositionSearch = new SimpleButton();
			this.txtCurrentSiteId = new TextEdit();
			this.labelControl4 = new LabelControl();
			this.btnGlobalRegistration = new SimpleButton();
			this.btnFindEquipment = new SimpleButton();
			this.btnConnectEquipment = new SimpleButton();
			this.txtExpectedSpeed = new TextEdit();
			this.btnExpectedSpeedSetting = new SimpleButton();
			this.btnRelativeDisplacementSetting = new SimpleButton();
			this.btnAbsolutePositionSetting = new SimpleButton();
			this.btnEncoderPositionSetting = new SimpleButton();
			this.btnORG = new SimpleButton();
			this.btnOffline = new SimpleButton();
			this.treeListEquipment = new TreeList();
			this.treeListColumnSiteId = new TreeListColumn();
			this.treeListColumnModel = new TreeListColumn();
			this.treeListColumnFirmwareNumber = new TreeListColumn();
			this.cmbEquipment = new ComboBoxEdit();
			this.rtxtMessage = new RichTextBox();
			this.labelControl2 = new LabelControl();
			this.labelControl1 = new LabelControl();
			this.chckRTCN = new CheckEdit();
			this.layoutControlGroup1 = new LayoutControlGroup();
			this.layoutControlItem3 = new LayoutControlItem();
			this.layoutControlItem6 = new LayoutControlItem();
			this.layoutControlItem9 = new LayoutControlItem();
			this.layoutControlItem10 = new LayoutControlItem();
			this.layoutControlItem4 = new LayoutControlItem();
			this.layoutControlItem5 = new LayoutControlItem();
			this.layoutControlItem16 = new LayoutControlItem();
			this.layoutControlItem7 = new LayoutControlItem();
			this.layoutControlItem12 = new LayoutControlItem();
			this.layoutControlItem15 = new LayoutControlItem();
			this.layoutControlItem17 = new LayoutControlItem();
			this.layoutControlItem18 = new LayoutControlItem();
			this.layoutControlItem23 = new LayoutControlItem();
			this.layoutControlItem25 = new LayoutControlItem();
			this.layoutControlItem26 = new LayoutControlItem();
			this.layoutControlItem2 = new LayoutControlItem();
			this.layoutControlItem27 = new LayoutControlItem();
			this.emptySpaceItem4 = new EmptySpaceItem();
			this.layoutControlItem8 = new LayoutControlItem();
			this.emptySpaceItem3 = new EmptySpaceItem();
			this.emptySpaceItem1 = new EmptySpaceItem();
			this.layoutControlItem28 = new LayoutControlItem();
			this.layoutControlItem29 = new LayoutControlItem();
			this.layoutControlItem30 = new LayoutControlItem();
			this.layoutControlItem31 = new LayoutControlItem();
			this.layoutControlItem32 = new LayoutControlItem();
			this.emptySpaceItem6 = new EmptySpaceItem();
			this.emptySpaceItem5 = new EmptySpaceItem();
			this.layoutControlItem1 = new LayoutControlItem();
			this.layoutControlItem13 = new LayoutControlItem();
			this.layoutControlItem22 = new LayoutControlItem();
			this.layoutControlItem11 = new LayoutControlItem();
			this.emptySpaceItem2 = new EmptySpaceItem();
			this.emptySpaceItem7 = new EmptySpaceItem();
			this.emptySpaceItem8 = new EmptySpaceItem();
			this.emptySpaceItem9 = new EmptySpaceItem();
			this.emptySpaceItem10 = new EmptySpaceItem();
			this.emptySpaceItem11 = new EmptySpaceItem();
			((ISupportInitialize)this.layoutControl1).BeginInit();
			this.layoutControl1.SuspendLayout();
			((ISupportInitialize)this.txtEncoderPosition.Properties).BeginInit();
			((ISupportInitialize)this.txtRelativeDisplacement.Properties).BeginInit();
			((ISupportInitialize)this.txtAbsolutePosition.Properties).BeginInit();
			((ISupportInitialize)this.txtCurrentSiteId.Properties).BeginInit();
			((ISupportInitialize)this.txtExpectedSpeed.Properties).BeginInit();
			((ISupportInitialize)this.treeListEquipment).BeginInit();
			((ISupportInitialize)this.cmbEquipment.Properties).BeginInit();
			((ISupportInitialize)this.chckRTCN.Properties).BeginInit();
			((ISupportInitialize)this.layoutControlGroup1).BeginInit();
			((ISupportInitialize)this.layoutControlItem3).BeginInit();
			((ISupportInitialize)this.layoutControlItem6).BeginInit();
			((ISupportInitialize)this.layoutControlItem9).BeginInit();
			((ISupportInitialize)this.layoutControlItem10).BeginInit();
			((ISupportInitialize)this.layoutControlItem4).BeginInit();
			((ISupportInitialize)this.layoutControlItem5).BeginInit();
			((ISupportInitialize)this.layoutControlItem16).BeginInit();
			((ISupportInitialize)this.layoutControlItem7).BeginInit();
			((ISupportInitialize)this.layoutControlItem12).BeginInit();
			((ISupportInitialize)this.layoutControlItem15).BeginInit();
			((ISupportInitialize)this.layoutControlItem17).BeginInit();
			((ISupportInitialize)this.layoutControlItem18).BeginInit();
			((ISupportInitialize)this.layoutControlItem23).BeginInit();
			((ISupportInitialize)this.layoutControlItem25).BeginInit();
			((ISupportInitialize)this.layoutControlItem26).BeginInit();
			((ISupportInitialize)this.layoutControlItem2).BeginInit();
			((ISupportInitialize)this.layoutControlItem27).BeginInit();
			((ISupportInitialize)this.emptySpaceItem4).BeginInit();
			((ISupportInitialize)this.layoutControlItem8).BeginInit();
			((ISupportInitialize)this.emptySpaceItem3).BeginInit();
			((ISupportInitialize)this.emptySpaceItem1).BeginInit();
			((ISupportInitialize)this.layoutControlItem28).BeginInit();
			((ISupportInitialize)this.layoutControlItem29).BeginInit();
			((ISupportInitialize)this.layoutControlItem30).BeginInit();
			((ISupportInitialize)this.layoutControlItem31).BeginInit();
			((ISupportInitialize)this.layoutControlItem32).BeginInit();
			((ISupportInitialize)this.emptySpaceItem6).BeginInit();
			((ISupportInitialize)this.emptySpaceItem5).BeginInit();
			((ISupportInitialize)this.layoutControlItem1).BeginInit();
			((ISupportInitialize)this.layoutControlItem13).BeginInit();
			((ISupportInitialize)this.layoutControlItem22).BeginInit();
			((ISupportInitialize)this.layoutControlItem11).BeginInit();
			((ISupportInitialize)this.emptySpaceItem2).BeginInit();
			((ISupportInitialize)this.emptySpaceItem7).BeginInit();
			((ISupportInitialize)this.emptySpaceItem8).BeginInit();
			((ISupportInitialize)this.emptySpaceItem9).BeginInit();
			((ISupportInitialize)this.emptySpaceItem10).BeginInit();
			((ISupportInitialize)this.emptySpaceItem11).BeginInit();
			base.SuspendLayout();
			this.layoutControl1.Controls.Add(this.btnEnable);
			this.layoutControl1.Controls.Add(this.txtEncoderPosition);
			this.layoutControl1.Controls.Add(this.txtRelativeDisplacement);
			this.layoutControl1.Controls.Add(this.txtAbsolutePosition);
			this.layoutControl1.Controls.Add(this.btnFBK);
			this.layoutControl1.Controls.Add(this.btnExpectedSpeedSearch);
			this.layoutControl1.Controls.Add(this.btntxtRelativeDisplacementSearch);
			this.layoutControl1.Controls.Add(this.btnAbsolutePositionSearch);
			this.layoutControl1.Controls.Add(this.btnEncoderPositionSearch);
			this.layoutControl1.Controls.Add(this.txtCurrentSiteId);
			this.layoutControl1.Controls.Add(this.labelControl4);
			this.layoutControl1.Controls.Add(this.btnGlobalRegistration);
			this.layoutControl1.Controls.Add(this.btnFindEquipment);
			this.layoutControl1.Controls.Add(this.btnConnectEquipment);
			this.layoutControl1.Controls.Add(this.txtExpectedSpeed);
			this.layoutControl1.Controls.Add(this.btnExpectedSpeedSetting);
			this.layoutControl1.Controls.Add(this.btnRelativeDisplacementSetting);
			this.layoutControl1.Controls.Add(this.btnAbsolutePositionSetting);
			this.layoutControl1.Controls.Add(this.btnEncoderPositionSetting);
			this.layoutControl1.Controls.Add(this.btnORG);
			this.layoutControl1.Controls.Add(this.btnOffline);
			this.layoutControl1.Controls.Add(this.treeListEquipment);
			this.layoutControl1.Controls.Add(this.cmbEquipment);
			this.layoutControl1.Controls.Add(this.rtxtMessage);
			this.layoutControl1.Controls.Add(this.labelControl2);
			this.layoutControl1.Controls.Add(this.labelControl1);
			this.layoutControl1.Controls.Add(this.chckRTCN);
			this.layoutControl1.Dock = DockStyle.Fill;
			this.layoutControl1.Location = new Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle?(new Rectangle(1081, 415, 506, 431));
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new Size(817, 745);
			this.layoutControl1.TabIndex = 0;
			this.layoutControl1.Text = "layoutControl1";
			this.btnEnable.Location = new Point(26, 570);
			this.btnEnable.Name = "btnEnable";
			this.btnEnable.Size = new Size(154, 27);
			this.btnEnable.StyleController = this.layoutControl1;
			this.btnEnable.TabIndex = 46;
			this.btnEnable.Text = "使能";
			this.btnEnable.Click += new EventHandler(this.btnEnable_Click);
			this.txtEncoderPosition.Location = new Point(105, 693);
			this.txtEncoderPosition.Name = "txtEncoderPosition";
			this.txtEncoderPosition.Properties.Mask.EditMask = "n0";
			this.txtEncoderPosition.Properties.Mask.MaskType = MaskType.Numeric;
			this.txtEncoderPosition.Size = new Size(188, 24);
			this.txtEncoderPosition.StyleController = this.layoutControl1;
			this.txtEncoderPosition.TabIndex = 45;
			this.txtRelativeDisplacement.Location = new Point(105, 633);
			this.txtRelativeDisplacement.Name = "txtRelativeDisplacement";
			this.txtRelativeDisplacement.Properties.Mask.EditMask = "n0";
			this.txtRelativeDisplacement.Properties.Mask.MaskType = MaskType.Numeric;
			this.txtRelativeDisplacement.Size = new Size(188, 24);
			this.txtRelativeDisplacement.StyleController = this.layoutControl1;
			this.txtRelativeDisplacement.TabIndex = 44;
			this.txtAbsolutePosition.Location = new Point(105, 663);
			this.txtAbsolutePosition.Name = "txtAbsolutePosition";
			this.txtAbsolutePosition.Properties.Mask.EditMask = "n0";
			this.txtAbsolutePosition.Properties.Mask.MaskType = MaskType.Numeric;
			this.txtAbsolutePosition.Size = new Size(188, 24);
			this.txtAbsolutePosition.StyleController = this.layoutControl1;
			this.txtAbsolutePosition.TabIndex = 43;
			this.btnFBK.Location = new Point(422, 570);
			this.btnFBK.Name = "btnFBK";
			this.btnFBK.Size = new Size(193, 27);
			this.btnFBK.StyleController = this.layoutControl1;
			this.btnFBK.TabIndex = 42;
			this.btnFBK.Text = "FBK";
			this.btnFBK.Click += new EventHandler(this.btnFBK_Click);
			this.btnExpectedSpeedSearch.Location = new Point(422, 603);
			this.btnExpectedSpeedSearch.Name = "btnExpectedSpeedSearch";
			this.btnExpectedSpeedSearch.Size = new Size(193, 27);
			this.btnExpectedSpeedSearch.StyleController = this.layoutControl1;
			this.btnExpectedSpeedSearch.TabIndex = 41;
			this.btnExpectedSpeedSearch.Text = "查询";
			this.btnExpectedSpeedSearch.Click += new EventHandler(this.btnExpectedSpeedSearch_Click);
			this.btntxtRelativeDisplacementSearch.Location = new Point(422, 636);
			this.btntxtRelativeDisplacementSearch.Name = "btntxtRelativeDisplacementSearch";
			this.btntxtRelativeDisplacementSearch.Size = new Size(193, 27);
			this.btntxtRelativeDisplacementSearch.StyleController = this.layoutControl1;
			this.btntxtRelativeDisplacementSearch.TabIndex = 40;
			this.btntxtRelativeDisplacementSearch.Text = "查询";
			this.btntxtRelativeDisplacementSearch.Click += new EventHandler(this.btntxtRelativeDisplacementSearch_Click);
			this.btnAbsolutePositionSearch.Location = new Point(422, 669);
			this.btnAbsolutePositionSearch.Name = "btnAbsolutePositionSearch";
			this.btnAbsolutePositionSearch.Size = new Size(193, 27);
			this.btnAbsolutePositionSearch.StyleController = this.layoutControl1;
			this.btnAbsolutePositionSearch.TabIndex = 39;
			this.btnAbsolutePositionSearch.Text = "查询";
			this.btnAbsolutePositionSearch.Click += new EventHandler(this.btnAbsolutePositionSearch_Click);
			this.btnEncoderPositionSearch.Location = new Point(422, 702);
			this.btnEncoderPositionSearch.Name = "btnEncoderPositionSearch";
			this.btnEncoderPositionSearch.Size = new Size(193, 27);
			this.btnEncoderPositionSearch.StyleController = this.layoutControl1;
			this.btnEncoderPositionSearch.TabIndex = 38;
			this.btnEncoderPositionSearch.Text = "查询";
			this.btnEncoderPositionSearch.Click += new EventHandler(this.btnEncoderPositionSearch_Click);
			this.txtCurrentSiteId.Location = new Point(539, 182);
			this.txtCurrentSiteId.Name = "txtCurrentSiteId";
			this.txtCurrentSiteId.Size = new Size(76, 24);
			this.txtCurrentSiteId.StyleController = this.layoutControl1;
			this.txtCurrentSiteId.TabIndex = 37;
			this.labelControl4.Location = new Point(539, 147);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new Size(76, 18);
			this.labelControl4.StyleController = this.layoutControl1;
			this.labelControl4.TabIndex = 36;
			this.labelControl4.Text = "当前站点ID";
			this.btnGlobalRegistration.Location = new Point(539, 102);
			this.btnGlobalRegistration.Name = "btnGlobalRegistration";
			this.btnGlobalRegistration.Size = new Size(76, 27);
			this.btnGlobalRegistration.StyleController = this.layoutControl1;
			this.btnGlobalRegistration.TabIndex = 35;
			this.btnGlobalRegistration.Text = "全局注册";
			this.btnGlobalRegistration.Click += new EventHandler(this.btnGlobalRegistration_Click);
			this.btnFindEquipment.Location = new Point(539, 16);
			this.btnFindEquipment.Name = "btnFindEquipment";
			this.btnFindEquipment.Size = new Size(76, 27);
			this.btnFindEquipment.StyleController = this.layoutControl1;
			this.btnFindEquipment.TabIndex = 34;
			this.btnFindEquipment.Text = "查找设备";
			this.btnFindEquipment.Click += new EventHandler(this.btnFindEquipment_Click);
			this.btnConnectEquipment.Location = new Point(539, 59);
			this.btnConnectEquipment.Name = "btnConnectEquipment";
			this.btnConnectEquipment.Size = new Size(76, 27);
			this.btnConnectEquipment.StyleController = this.layoutControl1;
			this.btnConnectEquipment.TabIndex = 33;
			this.btnConnectEquipment.Text = "连接设备";
			this.btnConnectEquipment.Click += new EventHandler(this.btnConnectEquipment_Click);
			this.txtExpectedSpeed.Location = new Point(105, 603);
			this.txtExpectedSpeed.Name = "txtExpectedSpeed";
			this.txtExpectedSpeed.Properties.Mask.EditMask = "n0";
			this.txtExpectedSpeed.Properties.Mask.MaskType = MaskType.Numeric;
			this.txtExpectedSpeed.Size = new Size(188, 24);
			this.txtExpectedSpeed.StyleController = this.layoutControl1;
			this.txtExpectedSpeed.TabIndex = 31;
			this.btnExpectedSpeedSetting.Location = new Point(309, 603);
			this.btnExpectedSpeedSetting.Name = "btnExpectedSpeedSetting";
			this.btnExpectedSpeedSetting.Size = new Size(97, 27);
			this.btnExpectedSpeedSetting.StyleController = this.layoutControl1;
			this.btnExpectedSpeedSetting.TabIndex = 26;
			this.btnExpectedSpeedSetting.Text = "设置";
			this.btnExpectedSpeedSetting.Click += new EventHandler(this.btnExpectedSpeedSetting_Click);
			this.btnRelativeDisplacementSetting.Location = new Point(309, 636);
			this.btnRelativeDisplacementSetting.Name = "btnRelativeDisplacementSetting";
			this.btnRelativeDisplacementSetting.Size = new Size(97, 27);
			this.btnRelativeDisplacementSetting.StyleController = this.layoutControl1;
			this.btnRelativeDisplacementSetting.TabIndex = 25;
			this.btnRelativeDisplacementSetting.Text = "设置";
			this.btnRelativeDisplacementSetting.Click += new EventHandler(this.btnRelativeDisplacementSetting_Click);
			this.btnAbsolutePositionSetting.Location = new Point(309, 669);
			this.btnAbsolutePositionSetting.Name = "btnAbsolutePositionSetting";
			this.btnAbsolutePositionSetting.Size = new Size(97, 27);
			this.btnAbsolutePositionSetting.StyleController = this.layoutControl1;
			this.btnAbsolutePositionSetting.TabIndex = 24;
			this.btnAbsolutePositionSetting.Text = "设置";
			this.btnAbsolutePositionSetting.Click += new EventHandler(this.btnAbsolutePositionSetting_Click);
			this.btnEncoderPositionSetting.Location = new Point(309, 702);
			this.btnEncoderPositionSetting.Name = "btnEncoderPositionSetting";
			this.btnEncoderPositionSetting.Size = new Size(97, 27);
			this.btnEncoderPositionSetting.StyleController = this.layoutControl1;
			this.btnEncoderPositionSetting.TabIndex = 22;
			this.btnEncoderPositionSetting.Text = "设置";
			this.btnEncoderPositionSetting.Click += new EventHandler(this.btnEncoderPositionSetting_Click);
			this.btnORG.Location = new Point(309, 570);
			this.btnORG.Name = "btnORG";
			this.btnORG.Size = new Size(97, 27);
			this.btnORG.StyleController = this.layoutControl1;
			this.btnORG.TabIndex = 20;
			this.btnORG.Text = "ORG";
			this.btnORG.Click += new EventHandler(this.btnORG_Click);
			this.btnOffline.Location = new Point(186, 570);
			this.btnOffline.Name = "btnOffline";
			this.btnOffline.Size = new Size(107, 27);
			this.btnOffline.StyleController = this.layoutControl1;
			this.btnOffline.TabIndex = 19;
			this.btnOffline.Text = "脱机";
			this.btnOffline.Click += new EventHandler(this.btnOffline_Click);
			this.treeListEquipment.Columns.AddRange(new TreeListColumn[]
			{
				this.treeListColumnSiteId,
				this.treeListColumnModel,
				this.treeListColumnFirmwareNumber
			});
			this.treeListEquipment.Cursor = Cursors.Default;
			this.treeListEquipment.Location = new Point(16, 46);
			this.treeListEquipment.Name = "treeListEquipment";
			this.treeListEquipment.Size = new Size(517, 518);
			this.treeListEquipment.TabIndex = 18;
			this.treeListEquipment.FocusedNodeChanged += new FocusedNodeChangedEventHandler(this.treeListEquipment_FocusedNodeChanged);
			this.treeListColumnSiteId.Caption = "站点ID";
			this.treeListColumnSiteId.FieldName = "站点ID";
			this.treeListColumnSiteId.Name = "treeListColumnSiteId";
			this.treeListColumnSiteId.Visible = true;
			this.treeListColumnSiteId.VisibleIndex = 0;
			this.treeListColumnModel.Caption = "型号";
			this.treeListColumnModel.FieldName = "型号";
			this.treeListColumnModel.Name = "treeListColumnModel";
			this.treeListColumnModel.Visible = true;
			this.treeListColumnModel.VisibleIndex = 1;
			this.treeListColumnFirmwareNumber.Caption = "固件号";
			this.treeListColumnFirmwareNumber.FieldName = "固件号";
			this.treeListColumnFirmwareNumber.Name = "treeListColumnFirmwareNumber";
			this.treeListColumnFirmwareNumber.Visible = true;
			this.treeListColumnFirmwareNumber.VisibleIndex = 2;
			this.cmbEquipment.Location = new Point(16, 16);
			this.cmbEquipment.Name = "cmbEquipment";
			this.cmbEquipment.Properties.Buttons.AddRange(new EditorButton[]
			{
				new EditorButton(ButtonPredefines.Combo)
			});
			this.cmbEquipment.Size = new Size(517, 24);
			this.cmbEquipment.StyleController = this.layoutControl1;
			this.cmbEquipment.TabIndex = 17;
			this.rtxtMessage.Location = new Point(621, 140);
			this.rtxtMessage.Name = "rtxtMessage";
			this.rtxtMessage.Size = new Size(180, 589);
			this.rtxtMessage.TabIndex = 16;
			this.rtxtMessage.Text = "";
			this.labelControl2.Location = new Point(621, 106);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new Size(124, 18);
			this.labelControl2.StyleController = this.layoutControl1;
			this.labelControl2.TabIndex = 15;
			this.labelControl2.Text = "828配置IOC,MFCG";
			this.labelControl1.Location = new Point(621, 54);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new Size(172, 36);
			this.labelControl1.StyleController = this.layoutControl1;
			this.labelControl1.TabIndex = 14;
			this.labelControl1.Text = "242需配置MCFG S12CON,\r\nS34CON";
			this.chckRTCN.Location = new Point(621, 16);
			this.chckRTCN.Name = "chckRTCN";
			this.chckRTCN.Properties.Caption = "开启RTNC实时消息反馈";
			this.chckRTCN.Size = new Size(180, 22);
			this.chckRTCN.StyleController = this.layoutControl1;
			this.chckRTCN.TabIndex = 13;
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new BaseLayoutItem[]
			{
				this.layoutControlItem3,
				this.layoutControlItem6,
				this.layoutControlItem9,
				this.layoutControlItem10,
				this.layoutControlItem4,
				this.layoutControlItem5,
				this.layoutControlItem16,
				this.layoutControlItem7,
				this.layoutControlItem12,
				this.layoutControlItem15,
				this.layoutControlItem17,
				this.layoutControlItem18,
				this.layoutControlItem23,
				this.layoutControlItem25,
				this.layoutControlItem26,
				this.layoutControlItem2,
				this.layoutControlItem27,
				this.emptySpaceItem4,
				this.layoutControlItem8,
				this.emptySpaceItem3,
				this.emptySpaceItem1,
				this.layoutControlItem28,
				this.layoutControlItem29,
				this.layoutControlItem30,
				this.layoutControlItem31,
				this.layoutControlItem32,
				this.emptySpaceItem6,
				this.emptySpaceItem5,
				this.layoutControlItem1,
				this.layoutControlItem13,
				this.layoutControlItem22,
				this.layoutControlItem11,
				this.emptySpaceItem2,
				this.emptySpaceItem7,
				this.emptySpaceItem8,
				this.emptySpaceItem9,
				this.emptySpaceItem10,
				this.emptySpaceItem11
			});
			this.layoutControlGroup1.Location = new Point(0, 0);
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
			this.layoutControlGroup1.Size = new Size(817, 745);
			this.layoutControlGroup1.TextVisible = false;
			this.layoutControlItem3.Control = this.chckRTCN;
			this.layoutControlItem3.Location = new Point(605, 0);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new Size(186, 28);
			this.layoutControlItem3.TextSize = new Size(0, 0);
			this.layoutControlItem3.TextVisible = false;
			this.layoutControlItem6.Control = this.labelControl1;
			this.layoutControlItem6.Location = new Point(605, 38);
			this.layoutControlItem6.Name = "layoutControlItem6";
			this.layoutControlItem6.Size = new Size(186, 42);
			this.layoutControlItem6.TextSize = new Size(0, 0);
			this.layoutControlItem6.TextVisible = false;
			this.layoutControlItem9.Control = this.labelControl2;
			this.layoutControlItem9.Location = new Point(605, 90);
			this.layoutControlItem9.Name = "layoutControlItem9";
			this.layoutControlItem9.Size = new Size(186, 24);
			this.layoutControlItem9.TextSize = new Size(0, 0);
			this.layoutControlItem9.TextVisible = false;
			this.layoutControlItem10.Control = this.rtxtMessage;
			this.layoutControlItem10.Location = new Point(605, 124);
			this.layoutControlItem10.Name = "layoutControlItem10";
			this.layoutControlItem10.Size = new Size(186, 595);
			this.layoutControlItem10.TextSize = new Size(0, 0);
			this.layoutControlItem10.TextVisible = false;
			this.layoutControlItem4.Control = this.cmbEquipment;
			this.layoutControlItem4.Location = new Point(0, 0);
			this.layoutControlItem4.Name = "layoutControlItem4";
			this.layoutControlItem4.Size = new Size(523, 30);
			this.layoutControlItem4.TextSize = new Size(0, 0);
			this.layoutControlItem4.TextVisible = false;
			this.layoutControlItem5.Control = this.treeListEquipment;
			this.layoutControlItem5.Location = new Point(0, 30);
			this.layoutControlItem5.Name = "layoutControlItem5";
			this.layoutControlItem5.Size = new Size(523, 524);
			this.layoutControlItem5.TextSize = new Size(0, 0);
			this.layoutControlItem5.TextVisible = false;
			this.layoutControlItem16.Control = this.btnOffline;
			this.layoutControlItem16.Location = new Point(170, 554);
			this.layoutControlItem16.Name = "layoutControlItem16";
			this.layoutControlItem16.Size = new Size(113, 33);
			this.layoutControlItem16.TextSize = new Size(0, 0);
			this.layoutControlItem16.TextVisible = false;
			this.layoutControlItem7.Control = this.btnORG;
			this.layoutControlItem7.Location = new Point(293, 554);
			this.layoutControlItem7.Name = "layoutControlItem7";
			this.layoutControlItem7.Size = new Size(103, 33);
			this.layoutControlItem7.TextSize = new Size(0, 0);
			this.layoutControlItem7.TextVisible = false;
			this.layoutControlItem12.Control = this.btnEncoderPositionSetting;
			this.layoutControlItem12.Location = new Point(293, 686);
			this.layoutControlItem12.Name = "layoutControlItem12";
			this.layoutControlItem12.Size = new Size(103, 33);
			this.layoutControlItem12.TextSize = new Size(0, 0);
			this.layoutControlItem12.TextVisible = false;
			this.layoutControlItem15.Control = this.btnAbsolutePositionSetting;
			this.layoutControlItem15.Location = new Point(293, 653);
			this.layoutControlItem15.Name = "layoutControlItem15";
			this.layoutControlItem15.Size = new Size(103, 33);
			this.layoutControlItem15.TextSize = new Size(0, 0);
			this.layoutControlItem15.TextVisible = false;
			this.layoutControlItem17.Control = this.btnRelativeDisplacementSetting;
			this.layoutControlItem17.Location = new Point(293, 620);
			this.layoutControlItem17.Name = "layoutControlItem17";
			this.layoutControlItem17.Size = new Size(103, 33);
			this.layoutControlItem17.TextSize = new Size(0, 0);
			this.layoutControlItem17.TextVisible = false;
			this.layoutControlItem18.Control = this.btnExpectedSpeedSetting;
			this.layoutControlItem18.Location = new Point(293, 587);
			this.layoutControlItem18.Name = "layoutControlItem18";
			this.layoutControlItem18.Size = new Size(103, 33);
			this.layoutControlItem18.TextSize = new Size(0, 0);
			this.layoutControlItem18.TextVisible = false;
			this.layoutControlItem23.Control = this.txtExpectedSpeed;
			this.layoutControlItem23.Location = new Point(10, 587);
			this.layoutControlItem23.Name = "layoutControlItem23";
			this.layoutControlItem23.Size = new Size(273, 30);
			this.layoutControlItem23.Text = "期望速度";
			this.layoutControlItem23.TextSize = new Size(75, 18);
			this.layoutControlItem25.Control = this.btnConnectEquipment;
			this.layoutControlItem25.Location = new Point(523, 43);
			this.layoutControlItem25.Name = "layoutControlItem25";
			this.layoutControlItem25.Size = new Size(82, 33);
			this.layoutControlItem25.TextSize = new Size(0, 0);
			this.layoutControlItem25.TextVisible = false;
			this.layoutControlItem26.Control = this.btnFindEquipment;
			this.layoutControlItem26.Location = new Point(523, 0);
			this.layoutControlItem26.Name = "layoutControlItem26";
			this.layoutControlItem26.Size = new Size(82, 33);
			this.layoutControlItem26.TextSize = new Size(0, 0);
			this.layoutControlItem26.TextVisible = false;
			this.layoutControlItem2.Control = this.btnGlobalRegistration;
			this.layoutControlItem2.Location = new Point(523, 86);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new Size(82, 33);
			this.layoutControlItem2.TextSize = new Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			this.layoutControlItem27.Control = this.labelControl4;
			this.layoutControlItem27.Location = new Point(523, 131);
			this.layoutControlItem27.Name = "layoutControlItem27";
			this.layoutControlItem27.Size = new Size(82, 24);
			this.layoutControlItem27.TextSize = new Size(0, 0);
			this.layoutControlItem27.TextVisible = false;
			this.emptySpaceItem4.AllowHotTrack = false;
			this.emptySpaceItem4.Location = new Point(523, 33);
			this.emptySpaceItem4.Name = "emptySpaceItem4";
			this.emptySpaceItem4.Size = new Size(82, 10);
			this.emptySpaceItem4.TextSize = new Size(0, 0);
			this.layoutControlItem8.Control = this.txtCurrentSiteId;
			this.layoutControlItem8.Location = new Point(523, 166);
			this.layoutControlItem8.Name = "layoutControlItem8";
			this.layoutControlItem8.Size = new Size(82, 30);
			this.layoutControlItem8.TextSize = new Size(0, 0);
			this.layoutControlItem8.TextVisible = false;
			this.emptySpaceItem3.AllowHotTrack = false;
			this.emptySpaceItem3.Location = new Point(523, 196);
			this.emptySpaceItem3.Name = "emptySpaceItem3";
			this.emptySpaceItem3.Size = new Size(82, 358);
			this.emptySpaceItem3.TextSize = new Size(0, 0);
			this.emptySpaceItem1.AllowHotTrack = false;
			this.emptySpaceItem1.Location = new Point(523, 119);
			this.emptySpaceItem1.Name = "emptySpaceItem1";
			this.emptySpaceItem1.Size = new Size(82, 12);
			this.emptySpaceItem1.TextSize = new Size(0, 0);
			this.layoutControlItem28.Control = this.btnEncoderPositionSearch;
			this.layoutControlItem28.Location = new Point(406, 686);
			this.layoutControlItem28.Name = "layoutControlItem28";
			this.layoutControlItem28.Size = new Size(199, 33);
			this.layoutControlItem28.TextSize = new Size(0, 0);
			this.layoutControlItem28.TextVisible = false;
			this.layoutControlItem29.Control = this.btnAbsolutePositionSearch;
			this.layoutControlItem29.Location = new Point(406, 653);
			this.layoutControlItem29.Name = "layoutControlItem29";
			this.layoutControlItem29.Size = new Size(199, 33);
			this.layoutControlItem29.TextSize = new Size(0, 0);
			this.layoutControlItem29.TextVisible = false;
			this.layoutControlItem30.Control = this.btntxtRelativeDisplacementSearch;
			this.layoutControlItem30.Location = new Point(406, 620);
			this.layoutControlItem30.Name = "layoutControlItem30";
			this.layoutControlItem30.Size = new Size(199, 33);
			this.layoutControlItem30.TextSize = new Size(0, 0);
			this.layoutControlItem30.TextVisible = false;
			this.layoutControlItem31.Control = this.btnExpectedSpeedSearch;
			this.layoutControlItem31.Location = new Point(406, 587);
			this.layoutControlItem31.Name = "layoutControlItem31";
			this.layoutControlItem31.Size = new Size(199, 33);
			this.layoutControlItem31.TextSize = new Size(0, 0);
			this.layoutControlItem31.TextVisible = false;
			this.layoutControlItem32.Control = this.btnFBK;
			this.layoutControlItem32.Location = new Point(406, 554);
			this.layoutControlItem32.Name = "layoutControlItem32";
			this.layoutControlItem32.Size = new Size(199, 33);
			this.layoutControlItem32.TextSize = new Size(0, 0);
			this.layoutControlItem32.TextVisible = false;
			this.emptySpaceItem6.AllowHotTrack = false;
			this.emptySpaceItem6.Location = new Point(523, 155);
			this.emptySpaceItem6.Name = "emptySpaceItem6";
			this.emptySpaceItem6.Size = new Size(82, 11);
			this.emptySpaceItem6.TextSize = new Size(0, 0);
			this.emptySpaceItem5.AllowHotTrack = false;
			this.emptySpaceItem5.Location = new Point(523, 76);
			this.emptySpaceItem5.Name = "emptySpaceItem5";
			this.emptySpaceItem5.Size = new Size(82, 10);
			this.emptySpaceItem5.TextSize = new Size(0, 0);
			this.layoutControlItem1.Control = this.txtAbsolutePosition;
			this.layoutControlItem1.Location = new Point(10, 647);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new Size(273, 30);
			this.layoutControlItem1.Text = "绝对位置";
			this.layoutControlItem1.TextSize = new Size(75, 18);
			this.layoutControlItem13.Control = this.txtRelativeDisplacement;
			this.layoutControlItem13.CustomizationFormText = "layoutControlItem13";
			this.layoutControlItem13.Location = new Point(10, 617);
			this.layoutControlItem13.Name = "layoutControlItem13";
			this.layoutControlItem13.Size = new Size(273, 30);
			this.layoutControlItem13.Text = "相对位移";
			this.layoutControlItem13.TextSize = new Size(75, 18);
			this.layoutControlItem22.Control = this.txtEncoderPosition;
			this.layoutControlItem22.Location = new Point(10, 677);
			this.layoutControlItem22.Name = "layoutControlItem22";
			this.layoutControlItem22.Size = new Size(273, 42);
			this.layoutControlItem22.Text = "编码器位置";
			this.layoutControlItem22.TextSize = new Size(75, 18);
			this.layoutControlItem11.Control = this.btnEnable;
			this.layoutControlItem11.Location = new Point(10, 554);
			this.layoutControlItem11.Name = "layoutControlItem11";
			this.layoutControlItem11.Size = new Size(160, 33);
			this.layoutControlItem11.TextSize = new Size(0, 0);
			this.layoutControlItem11.TextVisible = false;
			this.emptySpaceItem2.AllowHotTrack = false;
			this.emptySpaceItem2.Location = new Point(605, 114);
			this.emptySpaceItem2.Name = "emptySpaceItem2";
			this.emptySpaceItem2.Size = new Size(186, 10);
			this.emptySpaceItem2.TextSize = new Size(0, 0);
			this.emptySpaceItem7.AllowHotTrack = false;
			this.emptySpaceItem7.Location = new Point(605, 28);
			this.emptySpaceItem7.Name = "emptySpaceItem7";
			this.emptySpaceItem7.Size = new Size(186, 10);
			this.emptySpaceItem7.TextSize = new Size(0, 0);
			this.emptySpaceItem8.AllowHotTrack = false;
			this.emptySpaceItem8.Location = new Point(605, 80);
			this.emptySpaceItem8.Name = "emptySpaceItem8";
			this.emptySpaceItem8.Size = new Size(186, 10);
			this.emptySpaceItem8.TextSize = new Size(0, 0);
			this.emptySpaceItem9.AllowHotTrack = false;
			this.emptySpaceItem9.Location = new Point(396, 554);
			this.emptySpaceItem9.Name = "emptySpaceItem9";
			this.emptySpaceItem9.Size = new Size(10, 165);
			this.emptySpaceItem9.TextSize = new Size(0, 0);
			this.emptySpaceItem10.AllowHotTrack = false;
			this.emptySpaceItem10.Location = new Point(283, 554);
			this.emptySpaceItem10.Name = "emptySpaceItem10";
			this.emptySpaceItem10.Size = new Size(10, 165);
			this.emptySpaceItem10.TextSize = new Size(0, 0);
			this.emptySpaceItem11.AllowHotTrack = false;
			this.emptySpaceItem11.Location = new Point(0, 554);
			this.emptySpaceItem11.Name = "emptySpaceItem11";
			this.emptySpaceItem11.Size = new Size(10, 165);
			this.emptySpaceItem11.TextSize = new Size(0, 0);
			base.AutoScaleDimensions = new SizeF(8f, 18f);
			base.Controls.Add(this.layoutControl1);
			base.Name = "ucMainOther";
			base.Size = new Size(817, 745);
			((ISupportInitialize)this.layoutControl1).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((ISupportInitialize)this.txtEncoderPosition.Properties).EndInit();
			((ISupportInitialize)this.txtRelativeDisplacement.Properties).EndInit();
			((ISupportInitialize)this.txtAbsolutePosition.Properties).EndInit();
			((ISupportInitialize)this.txtCurrentSiteId.Properties).EndInit();
			((ISupportInitialize)this.txtExpectedSpeed.Properties).EndInit();
			((ISupportInitialize)this.treeListEquipment).EndInit();
			((ISupportInitialize)this.cmbEquipment.Properties).EndInit();
			((ISupportInitialize)this.chckRTCN.Properties).EndInit();
			((ISupportInitialize)this.layoutControlGroup1).EndInit();
			((ISupportInitialize)this.layoutControlItem3).EndInit();
			((ISupportInitialize)this.layoutControlItem6).EndInit();
			((ISupportInitialize)this.layoutControlItem9).EndInit();
			((ISupportInitialize)this.layoutControlItem10).EndInit();
			((ISupportInitialize)this.layoutControlItem4).EndInit();
			((ISupportInitialize)this.layoutControlItem5).EndInit();
			((ISupportInitialize)this.layoutControlItem16).EndInit();
			((ISupportInitialize)this.layoutControlItem7).EndInit();
			((ISupportInitialize)this.layoutControlItem12).EndInit();
			((ISupportInitialize)this.layoutControlItem15).EndInit();
			((ISupportInitialize)this.layoutControlItem17).EndInit();
			((ISupportInitialize)this.layoutControlItem18).EndInit();
			((ISupportInitialize)this.layoutControlItem23).EndInit();
			((ISupportInitialize)this.layoutControlItem25).EndInit();
			((ISupportInitialize)this.layoutControlItem26).EndInit();
			((ISupportInitialize)this.layoutControlItem2).EndInit();
			((ISupportInitialize)this.layoutControlItem27).EndInit();
			((ISupportInitialize)this.emptySpaceItem4).EndInit();
			((ISupportInitialize)this.layoutControlItem8).EndInit();
			((ISupportInitialize)this.emptySpaceItem3).EndInit();
			((ISupportInitialize)this.emptySpaceItem1).EndInit();
			((ISupportInitialize)this.layoutControlItem28).EndInit();
			((ISupportInitialize)this.layoutControlItem29).EndInit();
			((ISupportInitialize)this.layoutControlItem30).EndInit();
			((ISupportInitialize)this.layoutControlItem31).EndInit();
			((ISupportInitialize)this.layoutControlItem32).EndInit();
			((ISupportInitialize)this.emptySpaceItem6).EndInit();
			((ISupportInitialize)this.emptySpaceItem5).EndInit();
			((ISupportInitialize)this.layoutControlItem1).EndInit();
			((ISupportInitialize)this.layoutControlItem13).EndInit();
			((ISupportInitialize)this.layoutControlItem22).EndInit();
			((ISupportInitialize)this.layoutControlItem11).EndInit();
			((ISupportInitialize)this.emptySpaceItem2).EndInit();
			((ISupportInitialize)this.emptySpaceItem7).EndInit();
			((ISupportInitialize)this.emptySpaceItem8).EndInit();
			((ISupportInitialize)this.emptySpaceItem9).EndInit();
			((ISupportInitialize)this.emptySpaceItem10).EndInit();
			((ISupportInitialize)this.emptySpaceItem11).EndInit();
			base.ResumeLayout(false);
		}

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.RichTextBox rtxtMessage;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chckRTCN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEquipment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraTreeList.TreeList treeListEquipment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnEncoderPositionSetting;
        private DevExpress.XtraEditors.SimpleButton btnORG;
        private DevExpress.XtraEditors.SimpleButton btnOffline;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.SimpleButton btnExpectedSpeedSetting;
        private DevExpress.XtraEditors.SimpleButton btnRelativeDisplacementSetting;
        private DevExpress.XtraEditors.SimpleButton btnAbsolutePositionSetting;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraEditors.SimpleButton btnGlobalRegistration;
        private DevExpress.XtraEditors.SimpleButton btnFindEquipment;
        private DevExpress.XtraEditors.SimpleButton btnConnectEquipment;
        private DevExpress.XtraEditors.TextEdit txtExpectedSpeed;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtCurrentSiteId;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnFBK;
        private DevExpress.XtraEditors.SimpleButton btnExpectedSpeedSearch;
        private DevExpress.XtraEditors.SimpleButton btntxtRelativeDisplacementSearch;
        private DevExpress.XtraEditors.SimpleButton btnAbsolutePositionSearch;
        private DevExpress.XtraEditors.SimpleButton btnEncoderPositionSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem30;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.TextEdit txtEncoderPosition;
        private DevExpress.XtraEditors.TextEdit txtRelativeDisplacement;
        private DevExpress.XtraEditors.TextEdit txtAbsolutePosition;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraEditors.SimpleButton btnEnable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnSiteId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnModel;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumnFirmwareNumber;
    }
}
