using SipaaSODE.Types;
using SipaaSODE.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE
{
    public partial class UserAccountControl : App
    {
        App _app;
        public UserAccountControl(App app)
        {
            InitializeComponent();
            ThemeManager themeManager = new ThemeManager(this);
            themeManager.EnableSaero = false;
            themeManager.theme = Theme.Dark;
            _app = app;
            if (app.DeveloperName == null)
                label3.Text = "Developer : Unknown";
            else
                label3.Text = "Developer : " +app.DeveloperName;

            label2.Text = "Application name : " + app.Text;
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            TaskbarItem item = new TaskbarItem(_app, Program.desktop.flowLayoutPanel1);
            Program.desktop.manager.runningapps.Add(_app);
            _app.Permission = AppPermission.admin;
            _app.taskbarItem = item;
            _app.Show();
            this.Close();
        }
    }
}
