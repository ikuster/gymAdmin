namespace gymAdmin
{
    partial class PotvrdaBrisanja
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
            this.PanelBrisanje = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNePotvrdaBrisanja = new System.Windows.Forms.Button();
            this.BtnDaPotvrdaBrisanja = new System.Windows.Forms.Button();
            this.PanelBrisanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBrisanje
            // 
            this.PanelBrisanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelBrisanje.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelBrisanje.Controls.Add(this.BtnDaPotvrdaBrisanja);
            this.PanelBrisanje.Controls.Add(this.BtnNePotvrdaBrisanja);
            this.PanelBrisanje.Controls.Add(this.label1);
            this.PanelBrisanje.Location = new System.Drawing.Point(0, 0);
            this.PanelBrisanje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelBrisanje.Name = "PanelBrisanje";
            this.PanelBrisanje.Size = new System.Drawing.Size(284, 111);
            this.PanelBrisanje.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jeste li sigurni?";
            // 
            // BtnNePotvrdaBrisanja
            // 
            this.BtnNePotvrdaBrisanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNePotvrdaBrisanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnNePotvrdaBrisanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNePotvrdaBrisanja.FlatAppearance.BorderSize = 0;
            this.BtnNePotvrdaBrisanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNePotvrdaBrisanja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNePotvrdaBrisanja.Location = new System.Drawing.Point(26, 64);
            this.BtnNePotvrdaBrisanja.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNePotvrdaBrisanja.Name = "BtnNePotvrdaBrisanja";
            this.BtnNePotvrdaBrisanja.Size = new System.Drawing.Size(92, 29);
            this.BtnNePotvrdaBrisanja.TabIndex = 21;
            this.BtnNePotvrdaBrisanja.Text = "Ne";
            this.BtnNePotvrdaBrisanja.UseVisualStyleBackColor = false;
            this.BtnNePotvrdaBrisanja.Click += new System.EventHandler(this.BtnNePotvrdaBrisanja_Click);
            // 
            // BtnDaPotvrdaBrisanja
            // 
            this.BtnDaPotvrdaBrisanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDaPotvrdaBrisanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnDaPotvrdaBrisanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDaPotvrdaBrisanja.FlatAppearance.BorderSize = 0;
            this.BtnDaPotvrdaBrisanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDaPotvrdaBrisanja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDaPotvrdaBrisanja.Location = new System.Drawing.Point(168, 64);
            this.BtnDaPotvrdaBrisanja.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDaPotvrdaBrisanja.Name = "BtnDaPotvrdaBrisanja";
            this.BtnDaPotvrdaBrisanja.Size = new System.Drawing.Size(92, 29);
            this.BtnDaPotvrdaBrisanja.TabIndex = 22;
            this.BtnDaPotvrdaBrisanja.Text = "Da";
            this.BtnDaPotvrdaBrisanja.UseVisualStyleBackColor = false;
            // 
            // PotvrdaBrisanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.PanelBrisanje);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PotvrdaBrisanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PotvrdaBrisanja";
            this.PanelBrisanje.ResumeLayout(false);
            this.PanelBrisanje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBrisanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDaPotvrdaBrisanja;
        private System.Windows.Forms.Button BtnNePotvrdaBrisanja;
    }
}