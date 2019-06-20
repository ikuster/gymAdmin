namespace gymAdmin
{
    partial class Zaposlenici
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIzbrisiZaposlenika = new System.Windows.Forms.Button();
            this.buttonDodajZaposlenika = new System.Windows.Forms.Button();
            this.buttonUrediZaposlenika = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.buttonOsvježi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(31, 79);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(734, 227);
            this.dgvZaposlenici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis zaposlenika";
            // 
            // buttonIzbrisiZaposlenika
            // 
            this.buttonIzbrisiZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIzbrisiZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonIzbrisiZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIzbrisiZaposlenika.FlatAppearance.BorderSize = 0;
            this.buttonIzbrisiZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzbrisiZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIzbrisiZaposlenika.Location = new System.Drawing.Point(544, 318);
            this.buttonIzbrisiZaposlenika.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIzbrisiZaposlenika.Name = "buttonIzbrisiZaposlenika";
            this.buttonIzbrisiZaposlenika.Size = new System.Drawing.Size(63, 29);
            this.buttonIzbrisiZaposlenika.TabIndex = 27;
            this.buttonIzbrisiZaposlenika.Text = "Izbriši";
            this.buttonIzbrisiZaposlenika.UseVisualStyleBackColor = false;
            this.buttonIzbrisiZaposlenika.Click += new System.EventHandler(this.buttonIzbrisiZaposlenika_Click);
            // 
            // buttonDodajZaposlenika
            // 
            this.buttonDodajZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonDodajZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajZaposlenika.FlatAppearance.BorderSize = 0;
            this.buttonDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDodajZaposlenika.Location = new System.Drawing.Point(702, 318);
            this.buttonDodajZaposlenika.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDodajZaposlenika.Name = "buttonDodajZaposlenika";
            this.buttonDodajZaposlenika.Size = new System.Drawing.Size(63, 29);
            this.buttonDodajZaposlenika.TabIndex = 28;
            this.buttonDodajZaposlenika.Text = "Dodaj";
            this.buttonDodajZaposlenika.UseVisualStyleBackColor = false;
            this.buttonDodajZaposlenika.Click += new System.EventHandler(this.buttonDodajZaposlenika_Click);
            // 
            // buttonUrediZaposlenika
            // 
            this.buttonUrediZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUrediZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonUrediZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUrediZaposlenika.FlatAppearance.BorderSize = 0;
            this.buttonUrediZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUrediZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUrediZaposlenika.Location = new System.Drawing.Point(624, 318);
            this.buttonUrediZaposlenika.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUrediZaposlenika.Name = "buttonUrediZaposlenika";
            this.buttonUrediZaposlenika.Size = new System.Drawing.Size(63, 29);
            this.buttonUrediZaposlenika.TabIndex = 29;
            this.buttonUrediZaposlenika.Text = "Uredi";
            this.buttonUrediZaposlenika.UseVisualStyleBackColor = false;
            this.buttonUrediZaposlenika.Click += new System.EventHandler(this.buttonUrediZaposlenika_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(483, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Pretraga";
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Location = new System.Drawing.Point(550, 54);
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(215, 20);
            this.textBoxPretraga.TabIndex = 31;
            this.textBoxPretraga.TextChanged += new System.EventHandler(this.textBoxPretraga_TextChanged);
            // 
            // buttonOsvježi
            // 
            this.buttonOsvježi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOsvježi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonOsvježi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOsvježi.FlatAppearance.BorderSize = 0;
            this.buttonOsvježi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOsvježi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOsvježi.Location = new System.Drawing.Point(31, 318);
            this.buttonOsvježi.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOsvježi.Name = "buttonOsvježi";
            this.buttonOsvježi.Size = new System.Drawing.Size(63, 29);
            this.buttonOsvježi.TabIndex = 32;
            this.buttonOsvježi.Text = "Osvježi";
            this.buttonOsvježi.UseVisualStyleBackColor = false;
            this.buttonOsvježi.Click += new System.EventHandler(this.buttonOsvježi_Click);
            // 
            // Zaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOsvježi);
            this.Controls.Add(this.textBoxPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUrediZaposlenika);
            this.Controls.Add(this.buttonDodajZaposlenika);
            this.Controls.Add(this.buttonIzbrisiZaposlenika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZaposlenici);
            this.Name = "Zaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.Zaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIzbrisiZaposlenika;
        private System.Windows.Forms.Button buttonDodajZaposlenika;
        private System.Windows.Forms.Button buttonUrediZaposlenika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPretraga;
        private System.Windows.Forms.Button buttonOsvježi;
    }
}