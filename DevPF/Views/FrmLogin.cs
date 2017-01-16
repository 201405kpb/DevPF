using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using DevPF.Model;
using DevPF.Utils;
using Newtonsoft.Json;

namespace DevPF.Views
{
    public partial class FrmLogin : Form
    {
        private readonly LoginFormApi _login = null;
        private ClientLogin clientLogin = null;
        private string filepath = "data.json";

        public FrmLogin()
        {
            InitializeComponent();
            _login = new LoginFormApi();
            initClient();
        }

        private void initClient()
        {
            if (File.Exists(filepath))
            {
                clientLogin = JsonConvert.DeserializeObject<ClientLogin>(File.ReadAllText(filepath));
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.BtnLogin.Enabled = false;
                if (!string.IsNullOrEmpty(this.cbox_YHZH.Text) && !string.IsNullOrEmpty(this.txt_YHMM.Text))
                {
                    this.Bar_Progress.Visible = true;
                    ResultClass<string> userResultClass = CommonMethods.Login(this.cbox_YHZH.Text, this.txt_YHMM.Text);
                    if (userResultClass.Result)
                    {
                        DialogResult = DialogResult.OK;
                        bool remberuser = (bool) CE_YHZH.EditValue;
                        bool remberpassword = (bool) CE_YHMM.EditValue;
                        if (clientLogin==null)
                        {
                            clientLogin=new ClientLogin();
                        }
                        clientLogin.RemberUser = remberuser;
                        clientLogin.RemberPassword = remberpassword;
                        if (remberuser)
                        {
                            UserLogin userLogin = clientLogin.ContainLogion(cbox_YHZH.Text.Trim());
                            if (string.IsNullOrEmpty(userLogin.UserName))
                            {
                                userLogin.UserName = cbox_YHZH.Text;
                                userLogin.PassWord = remberpassword ? txt_YHMM.Text : "";
                                clientLogin.UserLogins.Add(userLogin);
                            }
                            else
                            {
                                userLogin.PassWord = remberpassword ? txt_YHMM.Text : "";
                                File.WriteAllText(filepath, JsonConvert.SerializeObject(clientLogin));
                                return;
                            }}
                        else
                        {
                            clientLogin.UserLogins.Clear();
                        }
                        File.WriteAllText(filepath, JsonConvert.SerializeObject(clientLogin));
                        
                    }
                    else
                    {
                        Bar_Progress.Visible = false;
                        XtraMessageBox.Show("连接数据库失败，请确认用户名和密码是否正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    Bar_Progress.Visible = false;
                    XtraMessageBox.Show("用户名和密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                BtnLogin.Enabled = true;
            }
            catch (Exception ex)
            {
                Bar_Progress.Visible = false;
                XtraMessageBox.Show("登录失败,原因：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("确定要退出吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _login.SetExitWindows(6, 300, this.Handle);
                Application.Exit();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (clientLogin!= null)
            {
                if (clientLogin.RemberUser)
                {
                    CE_YHZH.Checked = true;
                }
                if (clientLogin.RemberPassword)
                {
                    CE_YHMM.Checked = true;
                }
                if (clientLogin.UserLogins.Count>0)
                {
                    cbox_YHZH.Properties.Items.Clear();
                    foreach (UserLogin userLogin in clientLogin.UserLogins)
                    {
                        cbox_YHZH.Properties.Items.Add(userLogin);
                    }
                    cbox_YHZH.SelectedIndex = 0;
                }
            }
        }

        private void cbox_YHZH_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserLogin userLogin = (UserLogin) cbox_YHZH.SelectedItem;
            if (userLogin!= null)
            {
                txt_YHMM.Text = userLogin.PassWord;
            }
        }

        private void CE_YHZH_CheckedChanged(object sender, EventArgs e)
        {
            if (!CE_YHZH.Checked)
            {
                CE_YHMM.Checked = false;
            }

        }

        private void CE_YHMM_CheckedChanged(object sender, EventArgs e)
        {
            if (CE_YHMM.Checked)
            {
                CE_YHZH.Checked = true;
            }
        }

    }
}
