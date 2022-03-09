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

namespace SipaaSODE.Apps
{
    public partial class TestFrm : App
    {
        public TestFrm()
        {
            InitializeComponent();
            UI.ThemeManager themeMan = new UI.ThemeManager(this) { EnableSaero = false,theme = Program.desktop.globalTheme, };
        }
    }
}
