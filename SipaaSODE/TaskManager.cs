using SipaaSODE.Managers;
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
    public partial class TaskManager : App
    {
        UI.ThemeManager themeManager;
        public TaskManager()
        {
            InitializeComponent();
            GetRunningApps();
            themeManager = new ThemeManager(this);
            themeManager.EnableSaero = false;
            themeManager.theme = Theme.Light;
            Program.desktop.manager.runningapps.ItemAdded += Manager_AppStarted;
            Program.desktop.manager.runningapps.ItemRemoved += Manager_AppClosed;
        }

        private void Manager_AppClosed(object sender, EventArgs e)
        {
            GetRunningApps();
        }

        private void Manager_AppStarted(object sender, EventArgs e)
        {
            GetRunningApps();
        }

        public void GetRunningApps()
        {
            listView1.Items.Clear();
            foreach (App frm in Program.desktop.manager.runningapps)
            {
                String[] items = new String[] { frm.Name, frm.Permission.ToString(), frm.DeveloperName};
                ListViewItem tmpItem = new ListViewItem(items);
                tmpItem.Tag = frm;
                listView1.Items.Add(tmpItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems[0] != null)
                using (App app = (App)listView1.SelectedItems[0].Tag)
                {
                    app.Close();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetRunningApps();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {
            GetRunningApps();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
