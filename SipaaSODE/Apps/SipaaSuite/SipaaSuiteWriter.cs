using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SipaaSODE.Apps.SipaaSuite
{
    public partial class SipaaSuiteWriter : Types.App
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private Sipaa.Framework.SDropdownMenu sDropdownMenu1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolStripMenuItem returnToHomeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Sipaa.Framework.SButton sButton1;
        private Sipaa.Framework.SButton sButton2;
        private Sipaa.Framework.SDropdownMenu sDropdownMenu2;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private bool textChanged;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SipaaSuiteWriter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDropdownMenu1 = new Sipaa.Framework.SDropdownMenu(this.components);
            this.returnToHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.sDropdownMenu2 = new Sipaa.Framework.SDropdownMenu(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.sDropdownMenu1.SuspendLayout();
            this.sDropdownMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.sButton2);
            this.panel1.Controls.Add(this.sButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 49);
            this.panel1.TabIndex = 1;
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Bold);
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(13, 3);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(73, 43);
            this.sButton1.TabIndex = 0;
            this.sButton1.Text = "File";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.file_48px;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.plus___48px;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // sDropdownMenu1
            // 
            this.sDropdownMenu1.IsMainMenu = false;
            this.sDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.newToolStripMenuItem,
            this.returnToHomeToolStripMenuItem});
            this.sDropdownMenu1.MenuItemHeight = 25;
            this.sDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.sDropdownMenu1.Name = "sDropdownMenu1";
            this.sDropdownMenu1.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.sDropdownMenu1.Size = new System.Drawing.Size(167, 92);
            // 
            // returnToHomeToolStripMenuItem
            // 
            this.returnToHomeToolStripMenuItem.Name = "returnToHomeToolStripMenuItem";
            this.returnToHomeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.returnToHomeToolStripMenuItem.Text = "Return to home...";
            this.returnToHomeToolStripMenuItem.Click += new System.EventHandler(this.returnToHomeToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 94);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(843, 517);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 6;
            this.sButton2.BorderSize = 0;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Bold);
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(92, 3);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(73, 43);
            this.sButton2.TabIndex = 1;
            this.sButton2.Text = "Edit";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // sDropdownMenu2
            // 
            this.sDropdownMenu2.IsMainMenu = false;
            this.sDropdownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.cutToolStripMenuItem});
            this.sDropdownMenu2.MenuItemHeight = 25;
            this.sDropdownMenu2.MenuItemTextColor = System.Drawing.Color.Empty;
            this.sDropdownMenu2.Name = "sDropdownMenu2";
            this.sDropdownMenu2.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.sDropdownMenu2.Size = new System.Drawing.Size(104, 114);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.undo_48px;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.redo_48px;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.copy_48px;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.paste_48px;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.cut_48px;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::SipaaSODE.Properties.Resources.save_48px;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // SipaaSuiteWriter
            // 
            this.AppIcon = ((System.Drawing.Icon)(resources.GetObject("$this.AppIcon")));
            this.ClientSize = new System.Drawing.Size(843, 611);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SipaaSuiteWriter";
            this.Text = "SipaaSuite Writer";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.panel1.ResumeLayout(false);
            this.sDropdownMenu1.ResumeLayout(false);
            this.sDropdownMenu2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public SipaaSuiteWriter()
        {
            InitializeComponent();
            this.Text = "SipaaSuite Writer - Untitled";
            textChanged = false;
            UI.ThemeManager themeManager = new UI.ThemeManager(this);
            themeManager.EnableSaero = false;
            themeManager.theme = Program.desktop.globalTheme;
        }

        private void sButton1_Click(object sender, EventArgs e)
        {
            this.sDropdownMenu1.Show(sButton1, sButton1.Width, 0);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textChanged == false)
                textChanged = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            var dialog = new System.Windows.Forms.SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(dialog.FileName);
                this.Text = "SipaaSuite Writer - " + System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);
                textChanged = false;
            }
        }

        private void openFile()
        {
            var dialog = new System.Windows.Forms.OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(dialog.FileName);
                this.Text = "SipaaSuite Writer - " + System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textChanged)
            {
                var msgbox = MessageBox.Show("Do you want to save your file?", "SipaaSuite Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msgbox == DialogResult.Yes)
                {
                    saveFile();
                    openFile();
                }else if (msgbox == DialogResult.No)
                {
                    openFile();
                }else if (msgbox == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                openFile();
            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textChanged)
            {
                var msgbox = MessageBox.Show("Do you want to save your file?", "SipaaSuite Writer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msgbox == DialogResult.Yes)
                {
                    saveFile();
                    richTextBox1.Clear();
                }
                else if (msgbox == DialogResult.No)
                {
                    richTextBox1.Clear();
                }
                else if (msgbox == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                richTextBox1.Clear();
            }
        }

        private void returnToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.desktop.manager.StartAppIntoPanel(new SipaaSuiteHome(), Program.desktop.formpane, Program.desktop.flowLayoutPanel1);
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            this.sDropdownMenu2.Show(sButton2, sButton2.Width, 0);
        }
    }
}
