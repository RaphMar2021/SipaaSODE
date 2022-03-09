using SipaaSODE.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE.Types
{
    public class App : Form, INotifyPropertyChanged
    {
        public UI.TaskbarItem taskbarItem;
        private STitleBar titleBar;
        private System.Drawing.Icon _appIcon;
        private string _devName;
        private AppPermission _appPerm;

        public App()
        {
            titleBar = new STitleBar();
            titleBar.Dock = DockStyle.Top;
            titleBar.Parent = this;
            this.Controls.Add(titleBar);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Load += App_Load;
        }

        private void App_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle= FormBorderStyle.None;
            // Exeptions (dont show maximize button on dialogs...)
            if (this.Text == "Task Manager") { this.titleBar.EnableMaximizeButton = false; }
            else if (this.Text == "SipaaSuite : Home") { this.titleBar.EnableMaximizeButton = false; }
            else if (this.Name.Contains("Dialog")) { this.titleBar.EnableMaximizeButton = false; }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public System.Drawing.Icon AppIcon
        {
            get { return _appIcon; }
            set
            {
                if (value != _appIcon)
                {
                    _appIcon = value;
                    this.Icon = value;
                    OnPropertyChanged("AppIcon");
                }
            }
        }

        public string DeveloperName
        {
            get { return _devName; }
            set { _devName = value; }
        }
        [DefaultValue(AppPermission.normal)]
        public AppPermission Permission
        {
            get
            {
                return _appPerm;
            }
            set
            {
                _appPerm = value;
            }
         }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public enum AppPermission
    {
        less,
        normal,
        admin,
        system
    }
}
