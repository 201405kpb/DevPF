using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevPF.Model;
using DevPF.Utils;

namespace DevPF.Views
{
    public partial class FrmPTZControl : DevExpress.XtraEditors.XtraForm
    {
        private readonly int userid;
        public int m_lRealHandle = -1;
        public int m_lChannel = -1;
        private bool bAuto = false;
        public FrmPTZControl(int userid)
        {
            this.InitializeComponent();
            this.userid = userid;
        }


        private void btnAuto_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            if (!bAuto)
            {
                CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.AUTO);
                btnAuto.Text = "停止";
                bAuto = true;
            }
            else
            {
                CommonMethods.TurnInfo(this.userid, 0, 1,1, 0, speed, TurnEnum.AUTO);
                btnAuto.Text = "自动";
                bAuto = false;
            }
         
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.UP);
            btnUp.Text = "停止";

        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1, 1, 0, speed, TurnEnum.UP);
            btnUp.Text = "向上";
        }

        private void FrmPTZControl_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.DOWN);
            btnDown.Text = "停止";
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1,1, 0, speed, TurnEnum.DOWN);
            btnDown.Text = "向下";

        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.RIGHT);
            btnLeft.Text = "停止";
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1,1, 0, speed, TurnEnum.RIGHT);
            btnLeft.Text = "向左";
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.LEFT);
            btnRight.Text = "停止";
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            int speed = int.Parse(this.cmbSpeed.SelectedItem.ToString());
            CommonMethods.TurnInfo(this.userid, 0, 1, 0, 0, speed, TurnEnum.LEFT);
            btnRight.Text = "向右";
        }
    }
}