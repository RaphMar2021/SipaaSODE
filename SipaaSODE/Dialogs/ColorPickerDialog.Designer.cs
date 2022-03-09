namespace SipaaSODE.Dialogs
{
    partial class ColorPickerDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPickerDialog));
            this.colorWheel1 = new Cyotek.Windows.Forms.ColorWheel();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.SuspendLayout();
            // 
            // colorWheel1
            // 
            this.colorWheel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorWheel1.Location = new System.Drawing.Point(12, 51);
            this.colorWheel1.Name = "colorWheel1";
            this.colorWheel1.Size = new System.Drawing.Size(400, 342);
            this.colorWheel1.TabIndex = 1;
            this.colorWheel1.ColorChanged += new System.EventHandler(this.colorWheel1_ColorChanged);
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 0;
            this.sButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(350, 399);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(62, 39);
            this.sButton1.TabIndex = 2;
            this.sButton1.Text = "OK";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 6;
            this.sButton2.BorderSize = 0;
            this.sButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(262, 399);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(82, 39);
            this.sButton2.TabIndex = 3;
            this.sButton2.Text = "Cancel";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // ColorPickerDialog
            // 
            this.AppIcon = ((System.Drawing.Icon)(resources.GetObject("$this.AppIcon")));
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.sButton2);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.colorWheel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorPickerDialog";
            this.Text = "Pick a color...";
            this.Controls.SetChildIndex(this.colorWheel1, 0);
            this.Controls.SetChildIndex(this.sButton1, 0);
            this.Controls.SetChildIndex(this.sButton2, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Sipaa.Framework.SButton sButton1;
        private Sipaa.Framework.SButton sButton2;
        private Cyotek.Windows.Forms.ColorWheel colorWheel1;
    }
}