using SipaaSODE.Dialogs;
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
    public enum Tool
    {
        Erase,
        Fill,
        Brush
    }
    public partial class SipaaSuiteDraw : Types.App
    {
        Graphics g;
        Pen p;
        bool draw;
        int beginX, beginY;
        Tool t = Tool.Brush;

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public SipaaSuiteDraw()
        {
            InitializeComponent();
            g = noThemePanel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p = new Pen(Color.Black, 2);
            UI.ThemeManager themeManager = new UI.ThemeManager(this);
            themeManager.EnableSaero = false;
            themeManager.theme = Program.desktop.globalTheme;
        }

        private void DrawPänel_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            beginX = e.X;
            beginY = e.Y;
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void penColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ColorPickerDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                p.Color = dialog.pickedColor;
                noThemePanel2.BackColor = dialog.pickedColor;
            }
        }

        private void eraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Erase;
            label2.Text = "Pen Tool : " + t.ToString();
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Fill;
            label2.Text = "Pen Tool : " + t.ToString();
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Brush;
            label2.Text = "Pen Tool : " + t.ToString();
        }

        private void add1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float sizetoadd = 1;
            p.Width = p.Width + sizetoadd;
            label3.Text = "Pen Size : " + p.Width;
        }

        private void remove1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float sizetoremove = 1;
            p.Width = p.Width - sizetoremove;
            label3.Text = "Pen Size : " + p.Width;
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            sDropdownMenu2.Show(sButton2, sButton2.Width, 0);
        }

        private void SipaaSuiteDraw_SizeChanged(object sender, EventArgs e)
        {
            g = noThemePanel1.CreateGraphics();
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point point1 = new Point(beginX, beginY);
            Point point2 = new Point(e.X, e.Y);
            if (draw == true)
            {
                if (t == Tool.Brush)
                {
                    g.DrawLine(p, point1, point2);
                    beginX = e.X;
                    beginY = e.Y;
                }else if (t == Tool.Fill)
                {
                    using (SolidBrush b = new SolidBrush(p.Color))
                    g.FillRectangle(b, 0, 0, noThemePanel1.Width, noThemePanel1.Height);
                }else if (t == Tool.Erase)
                {
                    g.DrawLine(p, point1, point2);
                    beginX = e.X; beginY = e.Y;
                }
            }
      }
    }
}
