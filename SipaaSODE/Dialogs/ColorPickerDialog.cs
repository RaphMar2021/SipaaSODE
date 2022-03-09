using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE.Dialogs
{
    public partial class ColorPickerDialog : Types.App
    {
        public Color pickedColor;
        public ColorPickerDialog()
        {
            InitializeComponent();
            UI.ThemeManager themeManager = new UI.ThemeManager(this);
            themeManager.EnableSaero = false;
            themeManager.theme = Program.desktop.globalTheme;
            colorWheel1.BackColor = themeManager._palette.appBackgroundColor;
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            pickedColor = colorWheel1.Color;
            Close();
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colorWheel1_ColorChanged(object sender, EventArgs e)
        {

        }
    }
}
