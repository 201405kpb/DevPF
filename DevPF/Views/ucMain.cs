using System;
using System.Windows.Forms;


namespace DevPF.Views {
    public partial class ucMain : UserControl
    {
        public ucMain() {
            InitializeComponent();
            
        }

        Random r = new Random();
        private void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                UserControl control = Activator.CreateInstance(Type.GetType(typeName: e.Document.ControlTypeName)) as UserControl;
              
                e.Control = control;
            }
        }
    }
}
