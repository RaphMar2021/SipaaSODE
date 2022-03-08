using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sipaa.Framework;
using SipaaSODE.Types;
using SipaaSODE.UI;

namespace SipaaSODE.Managers
{
    public class AppManager
    {
        public WithEventsList<App> runningapps = new WithEventsList<App>();

        public bool KillApp(App app)
        {
            if (runningapps.Contains(app))
            {
                foreach (App f in runningapps)
                {
                    if (f.Name == app.Name)
                    {
                        f.Close();
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void StartApp(App app, FlowLayoutPanel pane)
        {
            if (app != null)
            {
                TaskbarItem item = new TaskbarItem(app, Program.desktop.flowLayoutPanel1);
                app.taskbarItem = item;
                app.FormClosed += App_FormClosed;
                app.Show();
                System.Threading.Thread.Sleep(10);
                runningapps.Add(app);
            }
        }

        public void StartAppIntoPanel(App app,Panel frm, FlowLayoutPanel pane)
        {
            if (app != null)
            {
                app.Location = new System.Drawing.Point(frm.Width / 2 - app.Width / 2, frm.Height / 2 - app.Height / 2);
                app.TopLevel = false;
                app.TopMost = false;
                app.FormClosed += App_FormClosed;
                frm.Controls.Add(app);
                if (app.Permission == AppPermission.admin)
                {
                    StartAppIntoPanel(new UserAccountControl(app), frm, pane);
                    
                } else if (app.Permission == AppPermission.system)
                {
                    new ToastMessage().showAlert("Sorry , we can't open this app \nbecause this app needs system permission", "SipaaSODE", ToastMessage.enmType.Error, ToastMessage.enmTheme.Dark);
                }
                else
                {
                    TaskbarItem item = new TaskbarItem(app, Program.desktop.flowLayoutPanel1);
                    app.taskbarItem = item;
                    app.Show();
                    System.Threading.Thread.Sleep(10);
                    runningapps.Add(app);
                }
            }
        }

        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            App sender2 = (App)sender;
            Program.desktop.flowLayoutPanel1.Controls.Remove(sender2.taskbarItem);
            System.Threading.Thread.Sleep(10);
            runningapps.Remove((App)sender);
        }
    }
    public class AppManagerEventArgs : EventArgs
    {
        public AppManagerEventArgs(App app)
        {
            Application = app;
        }

        App _app;

        public App Application
        {
            get { return _app; }
            set { _app = value; }
        }

    }
}
