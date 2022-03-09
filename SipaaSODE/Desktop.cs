// .NET imports
using System;
using System.Drawing;
using System.Windows.Forms;

// Desktop environment imports
using SipaaSODE.Apps;
using SipaaSODE.Apps.SipaaSuite;
using SipaaSODE.Managers;
using SipaaSODE.Types;
using SipaaSODE.UI;

namespace SipaaSODE
{
    public partial class Desktop : Form
    {
        public AppManager manager;
        public Panel formpane;
        public static ThemeManager themeManager;
        public Theme globalTheme = Theme.Light;
        public Desktop()
        {
            InitializeComponent();
            themeManager = new ThemeManager(this);
            themeManager.EnableSaero = false;
            themeManager.theme = globalTheme;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            manager = new AppManager();
            formpane = new Panel();
            formpane.BackgroundImage = Properties.Resources.sipaabg;
            formpane.BackgroundImageLayout = ImageLayout.Stretch;
            formpane.Parent = this;
            formpane.BackColor = Color.Transparent;
            formpane.Dock = DockStyle.Fill;
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            if (sPanel4.Visible)
            {
                sPanel4.Hide();
            }
            else
            {
                sPanel4.Show();
            }
        }

        public void OpenAppAndHideStartMenu(App app)
        {
            if (app == null)
                return;
            else
                manager.StartAppIntoPanel(app, formpane, this.flowLayoutPanel1);
            sPanel4.Hide();
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            OpenAppAndHideStartMenu(new TaskManager());
        }

        private void sButton3_Click(object sender, EventArgs e)
        {
            OpenAppAndHideStartMenu(new TestFrm());
        }

        private void sButton4_Click(object sender, EventArgs e)
        {
            OpenAppAndHideStartMenu(new SipaaSuiteHome());
        }
    }
}
