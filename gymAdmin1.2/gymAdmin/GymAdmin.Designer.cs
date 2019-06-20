namespace gymAdmin
{
    partial class GymAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymAdmin));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelActive = new System.Windows.Forms.Panel();
            this.BtnPocetna = new System.Windows.Forms.Button();
            this.BtnClanarine = new System.Windows.Forms.Button();
            this.BtnMjerenja = new System.Windows.Forms.Button();
            this.BtnZaposlenici = new System.Windows.Forms.Button();
            this.BtnKlijenti = new System.Windows.Forms.Button();
            this.PanelKlijenti = new System.Windows.Forms.Panel();
            this.BtnMjerenjaKlijenti = new System.Windows.Forms.Button();
            this.LblKlijenti = new System.Windows.Forms.Label();
            this.BtnPretraziKlijenti = new System.Windows.Forms.Button();
            this.TxtPretrazivanjeKlijenti = new System.Windows.Forms.TextBox();
            this.DGVklijenti = new System.Windows.Forms.DataGridView();
            this.BtnDetaljnoKlijenti = new System.Windows.Forms.Button();
            this.BtnIzbrisiKlijenti = new System.Windows.Forms.Button();
            this.BtnDodajKlijenti = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.PanelKlijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVklijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.PanelMenu.Controls.Add(this.PanelActive);
            this.PanelMenu.Controls.Add(this.BtnPocetna);
            this.PanelMenu.Controls.Add(this.BtnClanarine);
            this.PanelMenu.Controls.Add(this.BtnMjerenja);
            this.PanelMenu.Controls.Add(this.BtnZaposlenici);
            this.PanelMenu.Controls.Add(this.BtnKlijenti);
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(184, 461);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelActive
            // 
            this.PanelActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelActive.Location = new System.Drawing.Point(174, 69);
            this.PanelActive.Margin = new System.Windows.Forms.Padding(0);
            this.PanelActive.Name = "PanelActive";
            this.PanelActive.Size = new System.Drawing.Size(10, 69);
            this.PanelActive.TabIndex = 21;
            // 
            // BtnPocetna
            // 
            this.BtnPocetna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPocetna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnPocetna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPocetna.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPocetna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPocetna.Image = ((System.Drawing.Image)(resources.GetObject("BtnPocetna.Image")));
            this.BtnPocetna.Location = new System.Drawing.Point(0, 0);
            this.BtnPocetna.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPocetna.Name = "BtnPocetna";
            this.BtnPocetna.Size = new System.Drawing.Size(184, 69);
            this.BtnPocetna.TabIndex = 16;
            this.BtnPocetna.Text = "Početna";
            this.BtnPocetna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnPocetna.UseVisualStyleBackColor = false;
            this.BtnPocetna.Click += new System.EventHandler(this.BtnPocetna_Click);
            // 
            // BtnClanarine
            // 
            this.BtnClanarine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClanarine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnClanarine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClanarine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClanarine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClanarine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClanarine.Image = ((System.Drawing.Image)(resources.GetObject("BtnClanarine.Image")));
            this.BtnClanarine.Location = new System.Drawing.Point(0, 138);
            this.BtnClanarine.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClanarine.Name = "BtnClanarine";
            this.BtnClanarine.Size = new System.Drawing.Size(184, 69);
            this.BtnClanarine.TabIndex = 19;
            this.BtnClanarine.Text = "Članarine";
            this.BtnClanarine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnClanarine.UseVisualStyleBackColor = false;
            this.BtnClanarine.Click += new System.EventHandler(this.BtnClanarine_Click);
            // 
            // BtnMjerenja
            // 
            this.BtnMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMjerenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnMjerenja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMjerenja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMjerenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMjerenja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMjerenja.Image = ((System.Drawing.Image)(resources.GetObject("BtnMjerenja.Image")));
            this.BtnMjerenja.Location = new System.Drawing.Point(0, 207);
            this.BtnMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMjerenja.Name = "BtnMjerenja";
            this.BtnMjerenja.Size = new System.Drawing.Size(184, 69);
            this.BtnMjerenja.TabIndex = 20;
            this.BtnMjerenja.Text = "Mjerenja";
            this.BtnMjerenja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnMjerenja.UseVisualStyleBackColor = false;
            this.BtnMjerenja.Click += new System.EventHandler(this.BtnMjerenja_Click);
            // 
            // BtnZaposlenici
            // 
            this.BtnZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnZaposlenici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnZaposlenici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZaposlenici.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnZaposlenici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnZaposlenici.Image = ((System.Drawing.Image)(resources.GetObject("BtnZaposlenici.Image")));
            this.BtnZaposlenici.Location = new System.Drawing.Point(0, 276);
            this.BtnZaposlenici.Margin = new System.Windows.Forms.Padding(0);
            this.BtnZaposlenici.Name = "BtnZaposlenici";
            this.BtnZaposlenici.Size = new System.Drawing.Size(184, 69);
            this.BtnZaposlenici.TabIndex = 17;
            this.BtnZaposlenici.Text = "Zaposlenici";
            this.BtnZaposlenici.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnZaposlenici.UseVisualStyleBackColor = false;
            this.BtnZaposlenici.Click += new System.EventHandler(this.BtnZaposlenici_Click);
            // 
            // BtnKlijenti
            // 
            this.BtnKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKlijenti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnKlijenti.Image = ((System.Drawing.Image)(resources.GetObject("BtnKlijenti.Image")));
            this.BtnKlijenti.Location = new System.Drawing.Point(0, 69);
            this.BtnKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.BtnKlijenti.Name = "BtnKlijenti";
            this.BtnKlijenti.Size = new System.Drawing.Size(184, 69);
            this.BtnKlijenti.TabIndex = 18;
            this.BtnKlijenti.Text = "Klijenti";
            this.BtnKlijenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnKlijenti.UseVisualStyleBackColor = false;
            this.BtnKlijenti.Click += new System.EventHandler(this.BtnKlijenti_Click);
            // 
            // PanelKlijenti
            // 
            this.PanelKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelKlijenti.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelKlijenti.Controls.Add(this.BtnMjerenjaKlijenti);
            this.PanelKlijenti.Controls.Add(this.LblKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnPretraziKlijenti);
            this.PanelKlijenti.Controls.Add(this.TxtPretrazivanjeKlijenti);
            this.PanelKlijenti.Controls.Add(this.DGVklijenti);
            this.PanelKlijenti.Controls.Add(this.BtnDetaljnoKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnIzbrisiKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnDodajKlijenti);
            this.PanelKlijenti.Location = new System.Drawing.Point(184, 0);
            this.PanelKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.PanelKlijenti.Name = "PanelKlijenti";
            this.PanelKlijenti.Size = new System.Drawing.Size(800, 461);
            this.PanelKlijenti.TabIndex = 23;
            // 
            // BtnMjerenjaKlijenti
            // 
            this.BtnMjerenjaKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMjerenjaKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnMjerenjaKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMjerenjaKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnMjerenjaKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMjerenjaKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMjerenjaKlijenti.Location = new System.Drawing.Point(333, 306);
            this.BtnMjerenjaKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMjerenjaKlijenti.Name = "BtnMjerenjaKlijenti";
            this.BtnMjerenjaKlijenti.Size = new System.Drawing.Size(139, 29);
            this.BtnMjerenjaKlijenti.TabIndex = 23;
            this.BtnMjerenjaKlijenti.Text = "Mjerenja";
            this.BtnMjerenjaKlijenti.UseVisualStyleBackColor = false;
            this.BtnMjerenjaKlijenti.Click += new System.EventHandler(this.BtnMjerenjaKlijenti_Click);
            // 
            // LblKlijenti
            // 
            this.LblKlijenti.AutoSize = true;
            this.LblKlijenti.Location = new System.Drawing.Point(11, 38);
            this.LblKlijenti.Name = "LblKlijenti";
            this.LblKlijenti.Size = new System.Drawing.Size(57, 21);
            this.LblKlijenti.TabIndex = 22;
            this.LblKlijenti.Text = "Klijenti";
            // 
            // BtnPretraziKlijenti
            // 
            this.BtnPretraziKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPretraziKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnPretraziKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPretraziKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnPretraziKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPretraziKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPretraziKlijenti.Location = new System.Drawing.Point(646, 20);
            this.BtnPretraziKlijenti.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.BtnPretraziKlijenti.Name = "BtnPretraziKlijenti";
            this.BtnPretraziKlijenti.Size = new System.Drawing.Size(139, 29);
            this.BtnPretraziKlijenti.TabIndex = 16;
            this.BtnPretraziKlijenti.Text = "Pretraži";
            this.BtnPretraziKlijenti.UseVisualStyleBackColor = false;
            // 
            // TxtPretrazivanjeKlijenti
            // 
            this.TxtPretrazivanjeKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPretrazivanjeKlijenti.Location = new System.Drawing.Point(336, 20);
            this.TxtPretrazivanjeKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.TxtPretrazivanjeKlijenti.Name = "TxtPretrazivanjeKlijenti";
            this.TxtPretrazivanjeKlijenti.Size = new System.Drawing.Size(300, 29);
            this.TxtPretrazivanjeKlijenti.TabIndex = 18;
            // 
            // DGVklijenti
            // 
            this.DGVklijenti.AllowUserToOrderColumns = true;
            this.DGVklijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVklijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVklijenti.Location = new System.Drawing.Point(15, 62);
            this.DGVklijenti.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.DGVklijenti.Name = "DGVklijenti";
            this.DGVklijenti.Size = new System.Drawing.Size(770, 232);
            this.DGVklijenti.TabIndex = 17;
            // 
            // BtnDetaljnoKlijenti
            // 
            this.BtnDetaljnoKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDetaljnoKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnDetaljnoKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetaljnoKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnDetaljnoKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetaljnoKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDetaljnoKlijenti.Location = new System.Drawing.Point(646, 306);
            this.BtnDetaljnoKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDetaljnoKlijenti.Name = "BtnDetaljnoKlijenti";
            this.BtnDetaljnoKlijenti.Size = new System.Drawing.Size(139, 29);
            this.BtnDetaljnoKlijenti.TabIndex = 21;
            this.BtnDetaljnoKlijenti.Text = "Detalji";
            this.BtnDetaljnoKlijenti.UseVisualStyleBackColor = false;
            this.BtnDetaljnoKlijenti.Click += new System.EventHandler(this.BtnDetaljnoKlijenti_Click);
            // 
            // BtnIzbrisiKlijenti
            // 
            this.BtnIzbrisiKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIzbrisiKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnIzbrisiKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIzbrisiKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnIzbrisiKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzbrisiKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIzbrisiKlijenti.Location = new System.Drawing.Point(489, 306);
            this.BtnIzbrisiKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.BtnIzbrisiKlijenti.Name = "BtnIzbrisiKlijenti";
            this.BtnIzbrisiKlijenti.Size = new System.Drawing.Size(139, 29);
            this.BtnIzbrisiKlijenti.TabIndex = 20;
            this.BtnIzbrisiKlijenti.Text = "Izbriši";
            this.BtnIzbrisiKlijenti.UseVisualStyleBackColor = false;
            this.BtnIzbrisiKlijenti.Click += new System.EventHandler(this.BtnIzbrisiKlijenti_Click);
            // 
            // BtnDodajKlijenti
            // 
            this.BtnDodajKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDodajKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnDodajKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDodajKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnDodajKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDodajKlijenti.Location = new System.Drawing.Point(176, 306);
            this.BtnDodajKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDodajKlijenti.Name = "BtnDodajKlijenti";
            this.BtnDodajKlijenti.Size = new System.Drawing.Size(139, 29);
            this.BtnDodajKlijenti.TabIndex = 19;
            this.BtnDodajKlijenti.Text = "Dodaj novog";
            this.BtnDodajKlijenti.UseVisualStyleBackColor = false;
            this.BtnDodajKlijenti.Click += new System.EventHandler(this.BtnDodajKlijenti_Click);
            // 
            // GymAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.PanelKlijenti);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GymAdmin";
            this.Text = "GymAdmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelKlijenti.ResumeLayout(false);
            this.PanelKlijenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVklijenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BtnPocetna;
        private System.Windows.Forms.Button BtnClanarine;
        private System.Windows.Forms.Button BtnMjerenja;
        private System.Windows.Forms.Button BtnZaposlenici;
        private System.Windows.Forms.Button BtnKlijenti;
        private System.Windows.Forms.Panel PanelKlijenti;
        private System.Windows.Forms.Label LblKlijenti;
        private System.Windows.Forms.Button BtnPretraziKlijenti;
        private System.Windows.Forms.TextBox TxtPretrazivanjeKlijenti;
        private System.Windows.Forms.DataGridView DGVklijenti;
        private System.Windows.Forms.Button BtnDetaljnoKlijenti;
        private System.Windows.Forms.Button BtnIzbrisiKlijenti;
        private System.Windows.Forms.Button BtnDodajKlijenti;
        private System.Windows.Forms.Panel PanelActive;
        private System.Windows.Forms.Button BtnMjerenjaKlijenti;
    }
}

