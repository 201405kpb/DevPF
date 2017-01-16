using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.XtraBars.Navigation;
using DevPF.Views;

namespace DevPF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           BonusSkins.Register();
            SkinManager.EnableFormSkins();
            FrmLogin pLogin = new FrmLogin();
            pLogin.ShowDialog();
            if (pLogin.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
        }
    }
}
