using System.Drawing;

namespace SipaaSODE.Drawing
{
    public struct ColorPalette
    {
        public Color panelBackgroundColor;
        public Color appBackgroundColor;
        public Color globalForeColor;
        public int alpha; // Alpha is the transparency. If this value is 255 , the panels is opaque. Else , the panels will be transparent.

        public Color FromRGB(int r, int g, int b)
        {
            return Color.FromArgb(alpha, r, g, b);
        }
    }
}
