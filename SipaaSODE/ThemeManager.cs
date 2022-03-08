using Sipaa.Framework;
using SipaaSODE.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE.UI
{
    public enum Theme
    {
        Light,
        Dark
    }
    public class ThemeManager : Component
    {
        ColorPalette _palette;
        private Theme _theme;
        bool _enableSaero;
        Form _parent;

        #region Properties
        /// <summary>
        /// The theme of the application
        /// </summary>
        public Theme theme
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                SetupColorPalette();
            }
            
        }
        /// <summary>
        /// Enable Saero if this value is true.
        /// </summary>
        public bool EnableSaero
        {
            get { return _enableSaero; }
            set { _enableSaero = value; }
        }
        #endregion

        #region Necessary voids
        public ThemeManager(Form parent)
        {
            _parent = parent;
        }
        /// <summary>
        /// This method will setup the color palette for the theme.
        /// </summary>
        public void SetupColorPalette()
        {
            if (_theme == Theme.Light || _enableSaero == false)
            {
                _palette.alpha = 255;
                _palette.appBackgroundColor = Color.FromArgb(_palette.alpha, 255, 255, 255);
                _palette.globalForeColor = Color.Black;
                _palette.panelBackgroundColor = Color.FromArgb(_palette.alpha, 255, 250, 250);
            }else if (_theme == Theme.Light || _enableSaero == true)
            {
                _palette.alpha = 147;
                _palette.appBackgroundColor = Color.FromArgb(_palette.alpha, 255, 255, 255);
                _palette.globalForeColor = Color.Black;
                _palette.panelBackgroundColor = Color.FromArgb(_palette.alpha, 255, 250, 250);
            }
            if (_theme == Theme.Dark || _enableSaero == false)
            {
                _palette.alpha = 255;
                _palette.appBackgroundColor = Color.FromArgb(_palette.alpha, 0, 0, 0);
                _palette.globalForeColor = Color.White;
                _palette.panelBackgroundColor = Color.FromArgb(_palette.alpha, 100, 100, 100);
            }else if(_theme == Theme.Dark || _enableSaero == true)
            {
                _palette.alpha = 147;
                _palette.appBackgroundColor = Color.FromArgb(_palette.alpha, 0, 0, 0);
                _palette.globalForeColor = Color.White;
                _palette.panelBackgroundColor = Color.FromArgb(_palette.alpha, 100, 100, 100);
            }
            // Apply theme to button , panels etc...
            this._parent.BackColor = _palette.appBackgroundColor;
            foreach (Control c in this._parent.Controls)
            {
                if (c.GetType() == typeof(SButton))
                {
                    c.ForeColor = _palette.globalForeColor;
                    c.BackColor = Color.Transparent;
                }else if (c.GetType() == typeof(SPanel))
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (c2.GetType() == typeof(SButton))
                        {
                            c2.ForeColor = _palette.globalForeColor;
                            c2.BackColor = Color.Transparent;
                        }
                        else if (c2.GetType() == typeof(SPanel))
                        {
                            foreach (Control c3 in c2.Controls)
                            {
                                if (c3.GetType() == typeof(SButton))
                                {
                                    c3.ForeColor = _palette.globalForeColor;
                                    c3.BackColor = Color.Transparent;
                                }
                                else if (c3.GetType() == typeof(SPanel))
                                {
                                    c3.BackColor = _palette.panelBackgroundColor;
                                    c3.ForeColor = _palette.globalForeColor;
                                }
                                else if (c3.GetType() == typeof(Label))
                                {
                                    c3.BackColor = Color.Transparent;
                                    c3.ForeColor = _palette.globalForeColor;
                                }
                            }
                            c2.BackColor = _palette.panelBackgroundColor;
                            c2.ForeColor = _palette.globalForeColor;
                        }
                        else if (c2.GetType() == typeof(Label))
                        {
                            c2.BackColor = Color.Transparent;
                            c2.ForeColor = _palette.globalForeColor;
                        }
                    }
                    c.BackColor = _palette.panelBackgroundColor;
                    c.ForeColor = _palette.globalForeColor;
                }else if (c.GetType() == typeof(Label))
                {
                    c.BackColor = Color.Transparent;
                    c.ForeColor = _palette.globalForeColor;
                }else if (c.GetType() == typeof(STitleBar))
                {
                    STitleBar tb = (STitleBar)c;
                    tb.BackColor = _palette.panelBackgroundColor;
                    tb.ElementsForeColor = _palette.globalForeColor;
                }
            }
        }
        #endregion

        #region Util voids
        public Color FromRGB(int r, int g, int b)
        {
            return Color.FromArgb(_palette.alpha, r, g, b);
        }
        #endregion
    }
}
