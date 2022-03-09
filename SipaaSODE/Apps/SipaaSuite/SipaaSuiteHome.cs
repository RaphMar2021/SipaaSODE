using SipaaSODE.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE.Apps.SipaaSuite
{
    public partial class SipaaSuiteHome : App
    {
        public SipaaSuiteHome()
        {
            InitializeComponent();
            UI.ThemeManager thememan = new UI.ThemeManager(this);
            thememan.EnableSaero = false;
            thememan.theme = UI.Theme.Dark;
        }

        private void SipaaSuiteHome_Load(object sender, EventArgs e)
        {

        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            Program.desktop.manager.StartAppIntoPanel(new SipaaSuiteWriter(), Program.desktop.formpane, Program.desktop.flowLayoutPanel1);
            this.Close();
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            Program.desktop.manager.StartAppIntoPanel(new SipaaSuiteDraw(), Program.desktop.formpane, Program.desktop.flowLayoutPanel1);
            this.Close();
        }
    }
}
