namespace gymAdmin
{
    partial class Clanarine
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
            this.PanelKlijenti = new System.Windows.Forms.Panel();
            this.dgvClanarine = new System.Windows.Forms.DataGridView();
            this.LblKlijenti = new System.Windows.Forms.Label();
            this.BtnUrediClanarinu = new System.Windows.Forms.Button();
            this.BtnIzbrisiClanarinu = new System.Windows.Forms.Button();
            this.BtnDodajClanarinu = new System.Windows.Forms.Button();
            this.BtnOsvjeziClanarine = new System.Windows.Forms.Button();
            this.PanelKlijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelKlijenti
            // 
            this.PanelKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelKlijenti.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelKlijenti.Controls.Add(this.BtnOsvjeziClanarine);
            this.PanelKlijenti.Controls.Add(this.dgvClanarine);
            this.PanelKlijenti.Controls.Add(this.LblKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnUrediClanarinu);
            this.PanelKlijenti.Controls.Add(this.BtnIzbrisiClanarinu);
            this.PanelKlijenti.Controls.Add(this.BtnDodajClanarinu);
            this.PanelKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelKlijenti.Location = new System.Drawing.Point(0, 1);
            this.PanelKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.PanelKlijenti.Name = "PanelKlijenti";
            this.PanelKlijenti.Size = new System.Drawing.Size(801, 461);
            this.PanelKlijenti.TabIndex = 24;
            // 
            // dgvClanarine
            // 
            this.dgvClanarine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarine.Location = new System.Drawing.Point(15, 40);
            this.dgvClanarine.Name = "dgvClanarine";
            this.dgvClanarine.Size = new System.Drawing.Size(770, 196);
            this.dgvClanarine.TabIndex = 23;
            // 
            // LblKlijenti
            // 
            this.LblKlijenti.AutoSize = true;
            this.LblKlijenti.Location = new System.Drawing.Point(11, 8);
            this.LblKlijenti.Name = "LblKlijenti";
            this.LblKlijenti.Size = new System.Drawing.Size(76, 20);
            this.LblKlijenti.TabIndex = 22;
            this.LblKlijenti.Text = "Članarine";
            // 
            // BtnUrediClanarinu
            // 
            this.BtnUrediClanarinu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUrediClanarinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnUrediClanarinu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrediClanarinu.FlatAppearance.BorderSize = 0;
            this.BtnUrediClanarinu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUrediClanarinu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUrediClanarinu.Location = new System.Drawing.Point(647, 306);
            this.BtnUrediClanarinu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUrediClanarinu.Name = "BtnUrediClanarinu";
            this.BtnUrediClanarinu.Size = new System.Drawing.Size(139, 29);
            this.BtnUrediClanarinu.TabIndex = 21;
            this.BtnUrediClanarinu.Text = "Uredi";
            this.BtnUrediClanarinu.UseVisualStyleBackColor = false;
            this.BtnUrediClanarinu.Click += new System.EventHandler(this.BtnUrediClanarinu_Click);
            // 
            // BtnIzbrisiClanarinu
            // 
            this.BtnIzbrisiClanarinu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIzbrisiClanarinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnIzbrisiClanarinu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIzbrisiClanarinu.FlatAppearance.BorderSize = 0;
            this.BtnIzbrisiClanarinu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzbrisiClanarinu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIzbrisiClanarinu.Location = new System.Drawing.Point(490, 306);
            this.BtnIzbrisiClanarinu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIzbrisiClanarinu.Name = "BtnIzbrisiClanarinu";
            this.BtnIzbrisiClanarinu.Size = new System.Drawing.Size(139, 29);
            this.BtnIzbrisiClanarinu.TabIndex = 20;
            this.BtnIzbrisiClanarinu.Text = "Izbriši";
            this.BtnIzbrisiClanarinu.UseVisualStyleBackColor = false;
            this.BtnIzbrisiClanarinu.Click += new System.EventHandler(this.BtnIzbrisiClanarinu_Click);
            // 
            // BtnDodajClanarinu
            // 
            this.BtnDodajClanarinu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDodajClanarinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnDodajClanarinu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDodajClanarinu.FlatAppearance.BorderSize = 0;
            this.BtnDodajClanarinu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajClanarinu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDodajClanarinu.Location = new System.Drawing.Point(336, 306);
            this.BtnDodajClanarinu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDodajClanarinu.Name = "BtnDodajClanarinu";
            this.BtnDodajClanarinu.Size = new System.Drawing.Size(139, 29);
            this.BtnDodajClanarinu.TabIndex = 19;
            this.BtnDodajClanarinu.Text = "Dodaj";
            this.BtnDodajClanarinu.UseVisualStyleBackColor = false;
            this.BtnDodajClanarinu.Click += new System.EventHandler(this.BtnDodajClanarinu_Click);
            // 
            // BtnOsvjeziClanarine
            // 
            this.BtnOsvjeziClanarine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOsvjeziClanarine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnOsvjeziClanarine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOsvjeziClanarine.FlatAppearance.BorderSize = 0;
            this.BtnOsvjeziClanarine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOsvjeziClanarine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOsvjeziClanarine.Location = new System.Drawing.Point(185, 306);
            this.BtnOsvjeziClanarine.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOsvjeziClanarine.Name = "BtnOsvjeziClanarine";
            this.BtnOsvjeziClanarine.Size = new System.Drawing.Size(139, 29);
            this.BtnOsvjeziClanarine.TabIndex = 24;
            this.BtnOsvjeziClanarine.Text = "Osvjezi";
            this.BtnOsvjeziClanarine.UseVisualStyleBackColor = false;
            this.BtnOsvjeziClanarine.Click += new System.EventHandler(this.BtnOsvjeziClanarine_Click);
            // 
            // Clanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelKlijenti);
            this.Name = "Clanarine";
            this.Text = "Clanarine";
            this.Load += new System.EventHandler(this.Clanarine_Load);
            this.PanelKlijenti.ResumeLayout(false);
            this.PanelKlijenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelKlijenti;
        private System.Windows.Forms.Button BtnUrediClanarinu;
        private System.Windows.Forms.Button BtnIzbrisiClanarinu;
        private System.Windows.Forms.Button BtnDodajClanarinu;
        private System.Windows.Forms.Label LblKlijenti;
        private System.Windows.Forms.DataGridView dgvClanarine;
        private System.Windows.Forms.Button BtnOsvjeziClanarine;
    }
}