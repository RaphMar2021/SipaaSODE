namespace SipaaSODE
{
    partial class Desktop
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sPanel4 = new Sipaa.Framework.SPanel();
            this.sButton3 = new Sipaa.Framework.SButton();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.label1 = new System.Windows.Forms.Label();
            this.sButton4 = new Sipaa.Framework.SButton();
            this.sPanel1.SuspendLayout();
            this.sPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel1.BorderRadius = 0;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.sButton1);
            this.sPanel1.Controls.Add(this.flowLayoutPanel1);
            this.sPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(0, 515);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(793, 40);
            this.sPanel1.TabIndex = 0;
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.Transparent;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.Black;
            this.sButton1.Location = new System.Drawing.Point(3, 3);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(36, 34);
            this.sButton1.TabIndex = 0;
            this.sButton1.Text = "S";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 40);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // sPanel4
            // 
            this.sPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sPanel4.BackColor = System.Drawing.Color.White;
            this.sPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sPanel4.BorderRadius = 6;
            this.sPanel4.BorderSize = 0;
            this.sPanel4.Controls.Add(this.sButton4);
            this.sPanel4.Controls.Add(this.sButton3);
            this.sPanel4.Controls.Add(this.sButton2);
            this.sPanel4.Controls.Add(this.label1);
            this.sPanel4.ForeColor = System.Drawing.Color.Black;
            this.sPanel4.Location = new System.Drawing.Point(3, 161);
            this.sPanel4.Name = "sPanel4";
            this.sPanel4.Size = new System.Drawing.Size(301, 348);
            this.sPanel4.TabIndex = 1;
            this.sPanel4.Visible = false;
            // 
            // sButton3
            // 
            this.sButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton3.BorderRadius = 6;
            this.sButton3.BorderSize = 0;
            this.sButton3.FlatAppearance.BorderSize = 0;
            this.sButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sButton3.ForeColor = System.Drawing.Color.White;
            this.sButton3.Location = new System.Drawing.Point(14, 131);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(95, 87);
            this.sButton3.TabIndex = 2;
            this.sButton3.Text = "TestFrm";
            this.sButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sButton3.UseVisualStyleBackColor = false;
            this.sButton3.Click += new System.EventHandler(this.sButton3_Click);
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 6;
            this.sButton2.BorderSize = 0;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Image = global::SipaaSODE.Properties.Resources.system_task_48px;
            this.sButton2.Location = new System.Drawing.Point(14, 38);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(95, 87);
            this.sButton2.TabIndex = 1;
            this.sButton2.Text = "Task Manager";
            this.sButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pinned";
            // 
            // sButton4
            // 
            this.sButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton4.BorderRadius = 6;
            this.sButton4.BorderSize = 0;
            this.sButton4.FlatAppearance.BorderSize = 0;
            this.sButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sButton4.ForeColor = System.Drawing.Color.White;
            this.sButton4.Image = global::SipaaSODE.Properties.Resources.icons8_pen_48;
            this.sButton4.Location = new System.Drawing.Point(115, 38);
            this.sButton4.Name = "sButton4";
            this.sButton4.Size = new System.Drawing.Size(95, 87);
            this.sButton4.TabIndex = 3;
            this.sButton4.Text = "Sipaa Suite";
            this.sButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sButton4.UseVisualStyleBackColor = false;
            this.sButton4.Click += new System.EventHandler(this.sButton4_Click);
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SipaaSODE.Properties.Resources.sipaabg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 555);
            this.Controls.Add(this.sPanel4);
            this.Controls.Add(this.sPanel1);
            this.DoubleBuffered = true;
            this.Name = "Desktop";
            this.Text = "SipaaSODE";
            this.sPanel1.ResumeLayout(false);
            this.sPanel4.ResumeLayout(false);
            this.sPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sipaa.Framework.SPanel sPanel1;
        private Sipaa.Framework.SButton sButton1;
        private Sipaa.Framework.SPanel sPanel4;
        private Sipaa.Framework.SButton sButton3;
        private Sipaa.Framework.SButton sButton2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sipaa.Framework.SButton sButton4;
    }
}

