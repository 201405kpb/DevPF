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
using DevExpress.XtraTreeList;
using DevPF.Model;
using DevPF.Utils;

namespace DevPF.Views
{
    public partial class ucMainOther : DevExpress.XtraEditors.XtraUserControl
    {
        public ucMainOther()
        {
            InitializeComponent();
        }
        private void btnFindEquipment_Click(object sender, EventArgs e)
        {
            this.cmbEquipment.Properties.Items.Clear();
            ResultClass<List<int>> searchResultClass = CommonMethods.SearchDeviceInfo();
            if (searchResultClass.Result)
            {
                foreach (int siteid in searchResultClass.ResultInfo)
                {
                    this.cmbEquipment.Properties.Items.Add(siteid);
                }
            }
            else
            {
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnConnectEquipment_Click(object sender, EventArgs e)
        {
            if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.ConnectDeviceInfo(int.Parse(strdevice), 1);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnGlobalRegistration_Click(object sender, EventArgs e)
        {
            if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<List<DeviceClassResult>> searchResultClass = CommonMethods.GREGInfo(int.Parse(strdevice));
                if (searchResultClass.Result)
                {
                    this.treeListEquipment.Nodes.Clear();
                    List<DeviceClassResult> deviceList = searchResultClass.ResultInfo;
                    foreach (DeviceClassResult deviceClassResult in deviceList)
                    {
                        this.treeListEquipment.AppendNode(new object[]
						{
							deviceClassResult.NodeId,
							deviceClassResult.Name,
							deviceClassResult.Version
						}, -1);
                    }
                }
                else
                {
                    XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void treeListEquipment_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            string nodeid = e.Node.GetDisplayText("treeListColumnSiteId");
            this.txtCurrentSiteId.Text = nodeid;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.ENAInfo(int.Parse(this.txtCurrentSiteId.Text), SiteEnum.ENA);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.ENAInfo(int.Parse(this.txtCurrentSiteId.Text), SiteEnum.OFF);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnORG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.ORGInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), ORGORFBK.ORG);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnFBK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.ORGInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), ORGORFBK.FBK);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        /// <summary>
        /// 设置期望速度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExpectedSpeedSetting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtExpectedSpeed.Text))
            {
                XtraMessageBox.Show("请填写期望速度！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.SetSPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), int.Parse(this.txtExpectedSpeed.Text), SetEnum.SPD);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnRelativeDisplacementSetting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRelativeDisplacement.Text))
            {
                XtraMessageBox.Show("请填写相对位置！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.SetSPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), int.Parse(this.txtExpectedSpeed.Text), SetEnum.STP);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAbsolutePositionSetting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRelativeDisplacement.Text))
            {
                XtraMessageBox.Show("请填写绝对位置！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.SetSPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), int.Parse(this.txtExpectedSpeed.Text), SetEnum.POS);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnEncoderPositionSetting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtRelativeDisplacement.Text))
            {
                XtraMessageBox.Show("请填写编码器位置！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<DeviceClassResult> searchResultClass = CommonMethods.SetSPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), int.Parse(this.txtExpectedSpeed.Text), SetEnum.QEC);
                XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnExpectedSpeedSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<string> searchResultClass = CommonMethods.QuerySPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), QueryEnum.SPD);
                if (searchResultClass.Result)
                {
                    XtraMessageBox.Show(searchResultClass.ResultInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btntxtRelativeDisplacementSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<string> searchResultClass = CommonMethods.QuerySPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), QueryEnum.STP);
                if (searchResultClass.Result)
                {
                    XtraMessageBox.Show(searchResultClass.ResultInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnAbsolutePositionSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<string> searchResultClass = CommonMethods.QuerySPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), QueryEnum.POS);
                if (searchResultClass.Result)
                {
                    XtraMessageBox.Show(searchResultClass.ResultInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnEncoderPositionSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCurrentSiteId.Text))
            {
                XtraMessageBox.Show("请选择当前站点！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.cmbEquipment.SelectedIndex < 0)
            {
                XtraMessageBox.Show("请选择连接！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string strdevice = this.cmbEquipment.SelectedItem.ToString();
                ResultClass<string> searchResultClass = CommonMethods.QuerySPDInfo(int.Parse(strdevice), int.Parse(this.txtCurrentSiteId.Text), QueryEnum.QEC);
                if (searchResultClass.Result)
                {
                    XtraMessageBox.Show(searchResultClass.ResultInfo, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show(searchResultClass.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

    }
}
