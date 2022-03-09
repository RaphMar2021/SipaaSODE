using SipaaSODE.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE.UI
{
    public class STitleBar : System.Windows.Forms.UserControl
    {
        private Sipaa.Framework.SButton sButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Icon _icon;
        private Sipaa.Framework.SButton sButton2;
        App _parent;
        private Sipaa.Framework.SButton sButton3;
        private Color _eForeColor;
        private bool _disableMaximize;
        Sipaa.Framework.SEllipse ellipse;
        public STitleBar()
        {
            
            // Init components
            InitializeComponent();
            Form frm = (Form)this.Parent;
                _parent = (App)this.Parent;
        }

        public App Parent
        {
            get { return _parent; } set { _parent = value; ellipse = new Sipaa.Framework.SEllipse();
                Sipaa.Framework.SDragControl dragcontrol = new Sipaa.Framework.SDragControl();
                dragcontrol.TargetControl = this;
                ellipse.TargetControl = this._parent;
                ellipse.CornerRadius = 11;
                label1.Text = value.Text;
                value.TextChanged += _parent_TextChanged;
                value.PropertyChanged += _parent_PropertyChanged;
                pictureBox1.Image = value.Icon.ToBitmap();
                value.SizeChanged += Value_SizeChanged;
            }
        }

        private void Value_SizeChanged(object sender, EventArgs e)
        {
            if (Parent != null)
                if (Parent.WindowState == FormWindowState.Maximized)
                {
                    this.ellipse.CornerRadius = 0;
                }
                else
                {
                    this.ellipse.CornerRadius = 11;
                }
        }

        private void _parent_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            App app = (App)sender;
            this.pictureBox1.Image = app.AppIcon.ToBitmap();
        }

        private void _parent_TextChanged(object sender, EventArgs e)
        {
            App app = (App)sender;
            label1.Text = _parent.Text;
        }

        private void InitializeComponent()
        {
            this.sButton1 = new Sipaa.Framework.SButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.sButton3 = new Sipaa.Framework.SButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.Transparent;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 0;
            this.sButton1.BorderSize = 0;
            this.sButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.sButton1.ForeColor = System.Drawing.Color.Black;
            this.sButton1.Location = new System.Drawing.Point(298, 0);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(41, 45);
            this.sButton1.TabIndex = 0;
            this.sButton1.Text = "X";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "FormTitle";
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.Transparent;
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 0;
            this.sButton2.BorderSize = 0;
            this.sButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.sButton2.ForeColor = System.Drawing.Color.Black;
            this.sButton2.Location = new System.Drawing.Point(257, 0);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(41, 45);
            this.sButton2.TabIndex = 3;
            this.sButton2.Text = "O";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // sButton3
            // 
            this.sButton3.BackColor = System.Drawing.Color.Transparent;
            this.sButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton3.BorderRadius = 0;
            this.sButton3.BorderSize = 0;
            this.sButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.sButton3.FlatAppearance.BorderSize = 0;
            this.sButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.sButton3.ForeColor = System.Drawing.Color.Black;
            this.sButton3.Location = new System.Drawing.Point(216, 0);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(41, 45);
            this.sButton3.TabIndex = 4;
            this.sButton3.Text = "-";
            this.sButton3.UseVisualStyleBackColor = false;
            this.sButton3.Click += new System.EventHandler(this.sButton3_Click);
            // 
            // STitleBar
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sButton3);
            this.Controls.Add(this.sButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sButton1);
            this.Name = "STitleBar";
            this.Size = new System.Drawing.Size(339, 45);
            this.Load += new System.EventHandler(this.STitleBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void STitleBar_Load(object sender, EventArgs e)
        {

        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Close();
            }
            else
            {
                return;
            }
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            if (this._parent != null)
            {
                if (this._parent.WindowState == FormWindowState.Normal) { this._parent.WindowState = FormWindowState.Maximized; } else { this._parent.WindowState = FormWindowState.Normal; }
            }
        }

        public bool EnableMaximizeButton
        {
            get { return _disableMaximize; }
            set { _disableMaximize = value; sButton2.Visible = value; }
        }

        public Color ElementsForeColor
        {
            get { return _eForeColor; }
            set { _eForeColor = value;
                this.sButton1.ForeColor = value;
                this.sButton2.ForeColor = value;
                this.sButton3.ForeColor = value;
                this.label1.ForeColor = value;
            }
        }

        private void sButton3_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.WindowState = FormWindowState.Minimized;
            }
            else
            {
                return;
            }
        }
    }
}
