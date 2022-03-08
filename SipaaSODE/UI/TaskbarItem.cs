using Sipaa.Framework;
using SipaaSODE.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE.UI
{
    public class TaskbarItem : Sipaa.Framework.SButton
    {
        App _app;
        SDropdownMenu menu;
        IContainer components;
        public TaskbarItem(App app, FlowLayoutPanel pane)
        {
            // Set the same value for _app or app
            _app = app;
            // Right-click menu
            this.components = new Container();
            menu = new SDropdownMenu(this.components);
            ToolStripMenuItem appname = new ToolStripMenuItem();
            ToolStripMenuItem relaunchasadmin = new ToolStripMenuItem();
            ToolStripMenuItem close = new ToolStripMenuItem();
            appname.Image = _app.Icon.ToBitmap();
            appname.Text = app.Text;
            relaunchasadmin.Text = "Relaunch as administrator";
            relaunchasadmin.Click += Relaunchasadmin_Click;
            close.Text = "Close the application";
            close.Click += Close_Click;
            menu.Items.Add(appname); 
            menu.Items.Add(relaunchasadmin);
            menu.Items.Add(close);
            // Button properties
            this.ContextMenuStrip = menu;
            this.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.Size = new System.Drawing.Size(34, 34);
            this.Image = _app.Icon.ToBitmap();
            this.BackColor = System.Drawing.Color.Transparent;
            this.Click += TaskbarItem_Click;
            // Add the taskbar button to the SODE taskbar
            pane.Controls.Add(this);
        }

        private void Relaunchasadmin_Click(object sender, EventArgs e)
        {
            Program.desktop.manager.StartAppIntoPanel(new UserAccountControl(_app), Program.desktop.formpane, Program.desktop.flowLayoutPanel1);
            _app.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            _app.Close();
        }

        private void TaskbarItem_Click(object sender, EventArgs e)
        {
            if (_app.WindowState == FormWindowState.Normal)
                _app.WindowState = FormWindowState.Minimized;
            else
                _app.WindowState = FormWindowState.Normal;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TaskbarItem
            // 
            this.FlatAppearance.BorderSize = 0;
            this.ResumeLayout(false);

        }
    }
}
