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
            this.BtnOdjava = new System.Windows.Forms.Button();
            this.PanelActive = new System.Windows.Forms.Panel();
            this.BtnPocetna = new System.Windows.Forms.Button();
            this.BtnClanarine = new System.Windows.Forms.Button();
            this.BtnZaposlenici = new System.Windows.Forms.Button();
            this.BtnKlijenti = new System.Windows.Forms.Button();
            this.PanelKlijenti = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOsvjeziKlijenti = new System.Windows.Forms.Button();
            this.BtnMjerenjaKlijenti = new System.Windows.Forms.Button();
            this.LblKlijenti = new System.Windows.Forms.Label();
            this.TxtPretrazivanjeKlijenti = new System.Windows.Forms.TextBox();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.BtnAzurirajKlijenti = new System.Windows.Forms.Button();
            this.BtnIzbrisiKlijenti = new System.Windows.Forms.Button();
            this.BtnDodajKlijenti = new System.Windows.Forms.Button();
            this.PanelClanarine = new System.Windows.Forms.Panel();
            this.TxtPretraziClanarine = new System.Windows.Forms.TextBox();
            this.LblPretraziClanarine = new System.Windows.Forms.Label();
            this.BtnOsvjeziClanarine = new System.Windows.Forms.Button();
            this.dgvClanarine = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnUrediClanarinu = new System.Windows.Forms.Button();
            this.BtnIzbrisiClanarinu = new System.Windows.Forms.Button();
            this.BtnDodajClanarinu = new System.Windows.Forms.Button();
            this.PanelZaposlenici = new System.Windows.Forms.Panel();
            this.BtnOzvjeziZaposlenici = new System.Windows.Forms.Button();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUrediZaposlenika = new System.Windows.Forms.Button();
            this.buttonDodajZaposlenika = new System.Windows.Forms.Button();
            this.buttonIzbrisiZaposlenika = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.PanelPocetna = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelPrijavljeniKorisnik = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.PanelKlijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.PanelClanarine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).BeginInit();
            this.PanelZaposlenici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.PanelPocetna.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.PanelMenu.Controls.Add(this.BtnOdjava);
            this.PanelMenu.Controls.Add(this.PanelActive);
            this.PanelMenu.Controls.Add(this.BtnPocetna);
            this.PanelMenu.Controls.Add(this.BtnClanarine);
            this.PanelMenu.Controls.Add(this.BtnZaposlenici);
            this.PanelMenu.Controls.Add(this.BtnKlijenti);
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(184, 461);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnOdjava
            // 
            this.BtnOdjava.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOdjava.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOdjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOdjava.Image = ((System.Drawing.Image)(resources.GetObject("BtnOdjava.Image")));
            this.BtnOdjava.Location = new System.Drawing.Point(0, 276);
            this.BtnOdjava.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOdjava.Name = "BtnOdjava";
            this.BtnOdjava.Size = new System.Drawing.Size(184, 69);
            this.BtnOdjava.TabIndex = 22;
            this.BtnOdjava.Text = "Odjava";
            this.BtnOdjava.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnOdjava.UseVisualStyleBackColor = false;
            this.BtnOdjava.Click += new System.EventHandler(this.BtnOdjava_Click);
            // 
            // PanelActive
            // 
            this.PanelActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelActive.Location = new System.Drawing.Point(174, 0);
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
            this.BtnZaposlenici.Location = new System.Drawing.Point(0, 207);
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
            this.PanelKlijenti.Controls.Add(this.label1);
            this.PanelKlijenti.Controls.Add(this.buttonOsvjeziKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnMjerenjaKlijenti);
            this.PanelKlijenti.Controls.Add(this.LblKlijenti);
            this.PanelKlijenti.Controls.Add(this.TxtPretrazivanjeKlijenti);
            this.PanelKlijenti.Controls.Add(this.dgvKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnAzurirajKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnIzbrisiKlijenti);
            this.PanelKlijenti.Controls.Add(this.BtnDodajKlijenti);
            this.PanelKlijenti.Location = new System.Drawing.Point(184, 0);
            this.PanelKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.PanelKlijenti.Name = "PanelKlijenti";
            this.PanelKlijenti.Size = new System.Drawing.Size(800, 461);
            this.PanelKlijenti.TabIndex = 23;
            this.PanelKlijenti.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PanelKlijenti_HelpRequested);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pretraži po imenu:";
            // 
            // buttonOsvjeziKlijenti
            // 
            this.buttonOsvjeziKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOsvjeziKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonOsvjeziKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOsvjeziKlijenti.FlatAppearance.BorderSize = 0;
            this.buttonOsvjeziKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOsvjeziKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOsvjeziKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOsvjeziKlijenti.Location = new System.Drawing.Point(17, 292);
            this.buttonOsvjeziKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOsvjeziKlijenti.Name = "buttonOsvjeziKlijenti";
            this.buttonOsvjeziKlijenti.Size = new System.Drawing.Size(139, 29);
            this.buttonOsvjeziKlijenti.TabIndex = 24;
            this.buttonOsvjeziKlijenti.Text = "Osvježi";
            this.buttonOsvjeziKlijenti.UseVisualStyleBackColor = false;
            this.buttonOsvjeziKlijenti.Click += new System.EventHandler(this.buttonOsvjeziKlijenti_Click);
            // 
            // BtnMjerenjaKlijenti
            // 
            this.BtnMjerenjaKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMjerenjaKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnMjerenjaKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMjerenjaKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnMjerenjaKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMjerenjaKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMjerenjaKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMjerenjaKlijenti.Location = new System.Drawing.Point(178, 292);
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
            this.LblKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKlijenti.Location = new System.Drawing.Point(13, 27);
            this.LblKlijenti.Name = "LblKlijenti";
            this.LblKlijenti.Size = new System.Drawing.Size(58, 20);
            this.LblKlijenti.TabIndex = 22;
            this.LblKlijenti.Text = "Klijenti:";
            // 
            // TxtPretrazivanjeKlijenti
            // 
            this.TxtPretrazivanjeKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPretrazivanjeKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPretrazivanjeKlijenti.Location = new System.Drawing.Point(562, 24);
            this.TxtPretrazivanjeKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.TxtPretrazivanjeKlijenti.Name = "TxtPretrazivanjeKlijenti";
            this.TxtPretrazivanjeKlijenti.Size = new System.Drawing.Size(223, 26);
            this.TxtPretrazivanjeKlijenti.TabIndex = 18;
            this.TxtPretrazivanjeKlijenti.TextChanged += new System.EventHandler(this.TxtPretrazivanjeKlijenti_TextChanged);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToOrderColumns = true;
            this.dgvKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Location = new System.Drawing.Point(15, 56);
            this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.Size = new System.Drawing.Size(770, 227);
            this.dgvKlijenti.TabIndex = 17;
            // 
            // BtnAzurirajKlijenti
            // 
            this.BtnAzurirajKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAzurirajKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnAzurirajKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAzurirajKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnAzurirajKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAzurirajKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAzurirajKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAzurirajKlijenti.Location = new System.Drawing.Point(490, 292);
            this.BtnAzurirajKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAzurirajKlijenti.Name = "BtnAzurirajKlijenti";
            this.BtnAzurirajKlijenti.Size = new System.Drawing.Size(139, 29);
            this.BtnAzurirajKlijenti.TabIndex = 21;
            this.BtnAzurirajKlijenti.Text = "Uredi";
            this.BtnAzurirajKlijenti.UseVisualStyleBackColor = false;
            this.BtnAzurirajKlijenti.Click += new System.EventHandler(this.BtnAzurirajKlijenti_Click);
            // 
            // BtnIzbrisiKlijenti
            // 
            this.BtnIzbrisiKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIzbrisiKlijenti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnIzbrisiKlijenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIzbrisiKlijenti.FlatAppearance.BorderSize = 0;
            this.BtnIzbrisiKlijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzbrisiKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisiKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIzbrisiKlijenti.Location = new System.Drawing.Point(335, 292);
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
            this.BtnDodajKlijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDodajKlijenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDodajKlijenti.Location = new System.Drawing.Point(646, 292);
            this.BtnDodajKlijenti.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDodajKlijenti.Name = "BtnDodajKlijenti";
            this.BtnDodajKlijenti.Size = new System.Drawing.Size(139, 29);
            this.BtnDodajKlijenti.TabIndex = 19;
            this.BtnDodajKlijenti.Text = "Dodaj ";
            this.BtnDodajKlijenti.UseVisualStyleBackColor = false;
            this.BtnDodajKlijenti.Click += new System.EventHandler(this.BtnDodajKlijenti_Click);
            // 
            // PanelClanarine
            // 
            this.PanelClanarine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelClanarine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelClanarine.Controls.Add(this.TxtPretraziClanarine);
            this.PanelClanarine.Controls.Add(this.LblPretraziClanarine);
            this.PanelClanarine.Controls.Add(this.BtnOsvjeziClanarine);
            this.PanelClanarine.Controls.Add(this.dgvClanarine);
            this.PanelClanarine.Controls.Add(this.label2);
            this.PanelClanarine.Controls.Add(this.BtnUrediClanarinu);
            this.PanelClanarine.Controls.Add(this.BtnIzbrisiClanarinu);
            this.PanelClanarine.Controls.Add(this.BtnDodajClanarinu);
            this.PanelClanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelClanarine.Location = new System.Drawing.Point(184, 0);
            this.PanelClanarine.Margin = new System.Windows.Forms.Padding(0);
            this.PanelClanarine.Name = "PanelClanarine";
            this.PanelClanarine.Size = new System.Drawing.Size(801, 461);
            this.PanelClanarine.TabIndex = 25;
            this.PanelClanarine.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PanelClanarine_HelpRequested);
            // 
            // TxtPretraziClanarine
            // 
            this.TxtPretraziClanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPretraziClanarine.Location = new System.Drawing.Point(562, 24);
            this.TxtPretraziClanarine.Name = "TxtPretraziClanarine";
            this.TxtPretraziClanarine.Size = new System.Drawing.Size(223, 26);
            this.TxtPretraziClanarine.TabIndex = 26;
            this.TxtPretraziClanarine.TextChanged += new System.EventHandler(this.TxtPretraziClanarine_TextChanged);
            // 
            // LblPretraziClanarine
            // 
            this.LblPretraziClanarine.AutoSize = true;
            this.LblPretraziClanarine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPretraziClanarine.Location = new System.Drawing.Point(420, 27);
            this.LblPretraziClanarine.Name = "LblPretraziClanarine";
            this.LblPretraziClanarine.Size = new System.Drawing.Size(136, 20);
            this.LblPretraziClanarine.TabIndex = 25;
            this.LblPretraziClanarine.Text = "Pretraži po imenu:";
            // 
            // BtnOsvjeziClanarine
            // 
            this.BtnOsvjeziClanarine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOsvjeziClanarine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnOsvjeziClanarine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOsvjeziClanarine.FlatAppearance.BorderSize = 0;
            this.BtnOsvjeziClanarine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOsvjeziClanarine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOsvjeziClanarine.Location = new System.Drawing.Point(180, 292);
            this.BtnOsvjeziClanarine.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOsvjeziClanarine.Name = "BtnOsvjeziClanarine";
            this.BtnOsvjeziClanarine.Size = new System.Drawing.Size(139, 29);
            this.BtnOsvjeziClanarine.TabIndex = 24;
            this.BtnOsvjeziClanarine.Text = "Osvježi";
            this.BtnOsvjeziClanarine.UseVisualStyleBackColor = false;
            this.BtnOsvjeziClanarine.Click += new System.EventHandler(this.BtnOsvjeziClanarine_Click);
            // 
            // dgvClanarine
            // 
            this.dgvClanarine.AllowUserToResizeColumns = false;
            this.dgvClanarine.AllowUserToResizeRows = false;
            this.dgvClanarine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClanarine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanarine.Location = new System.Drawing.Point(15, 56);
            this.dgvClanarine.Margin = new System.Windows.Forms.Padding(15);
            this.dgvClanarine.Name = "dgvClanarine";
            this.dgvClanarine.Size = new System.Drawing.Size(770, 227);
            this.dgvClanarine.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Članarine:";
            // 
            // BtnUrediClanarinu
            // 
            this.BtnUrediClanarinu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUrediClanarinu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnUrediClanarinu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUrediClanarinu.FlatAppearance.BorderSize = 0;
            this.BtnUrediClanarinu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUrediClanarinu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUrediClanarinu.Location = new System.Drawing.Point(491, 292);
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
            this.BtnIzbrisiClanarinu.Location = new System.Drawing.Point(335, 292);
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
            this.BtnDodajClanarinu.Location = new System.Drawing.Point(646, 292);
            this.BtnDodajClanarinu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDodajClanarinu.Name = "BtnDodajClanarinu";
            this.BtnDodajClanarinu.Size = new System.Drawing.Size(139, 29);
            this.BtnDodajClanarinu.TabIndex = 19;
            this.BtnDodajClanarinu.Text = "Dodaj";
            this.BtnDodajClanarinu.UseVisualStyleBackColor = false;
            this.BtnDodajClanarinu.Click += new System.EventHandler(this.BtnDodajClanarinu_Click);
            // 
            // PanelZaposlenici
            // 
            this.PanelZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelZaposlenici.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelZaposlenici.Controls.Add(this.BtnOzvjeziZaposlenici);
            this.PanelZaposlenici.Controls.Add(this.textBoxPretraga);
            this.PanelZaposlenici.Controls.Add(this.label3);
            this.PanelZaposlenici.Controls.Add(this.buttonUrediZaposlenika);
            this.PanelZaposlenici.Controls.Add(this.buttonDodajZaposlenika);
            this.PanelZaposlenici.Controls.Add(this.buttonIzbrisiZaposlenika);
            this.PanelZaposlenici.Controls.Add(this.label4);
            this.PanelZaposlenici.Controls.Add(this.dgvZaposlenici);
            this.PanelZaposlenici.Location = new System.Drawing.Point(184, 0);
            this.PanelZaposlenici.Margin = new System.Windows.Forms.Padding(0);
            this.PanelZaposlenici.Name = "PanelZaposlenici";
            this.PanelZaposlenici.Size = new System.Drawing.Size(801, 461);
            this.PanelZaposlenici.TabIndex = 26;
            // 
            // BtnOzvjeziZaposlenici
            // 
            this.BtnOzvjeziZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOzvjeziZaposlenici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnOzvjeziZaposlenici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOzvjeziZaposlenici.FlatAppearance.BorderSize = 0;
            this.BtnOzvjeziZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOzvjeziZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOzvjeziZaposlenici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOzvjeziZaposlenici.Location = new System.Drawing.Point(180, 292);
            this.BtnOzvjeziZaposlenici.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOzvjeziZaposlenici.Name = "BtnOzvjeziZaposlenici";
            this.BtnOzvjeziZaposlenici.Size = new System.Drawing.Size(139, 29);
            this.BtnOzvjeziZaposlenici.TabIndex = 40;
            this.BtnOzvjeziZaposlenici.Text = "Osvježi";
            this.BtnOzvjeziZaposlenici.UseVisualStyleBackColor = false;
            this.BtnOzvjeziZaposlenici.Click += new System.EventHandler(this.BtnOzvjeziZaposlenici_Click);
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPretraga.Location = new System.Drawing.Point(562, 24);
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(223, 26);
            this.textBoxPretraga.TabIndex = 39;
            this.textBoxPretraga.TextChanged += new System.EventHandler(this.textBoxPretraga_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pretraži po imenu:";
            // 
            // buttonUrediZaposlenika
            // 
            this.buttonUrediZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUrediZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonUrediZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUrediZaposlenika.FlatAppearance.BorderSize = 0;
            this.buttonUrediZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUrediZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUrediZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUrediZaposlenika.Location = new System.Drawing.Point(491, 292);
            this.buttonUrediZaposlenika.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUrediZaposlenika.Name = "buttonUrediZaposlenika";
            this.buttonUrediZaposlenika.Size = new System.Drawing.Size(139, 29);
            this.buttonUrediZaposlenika.TabIndex = 37;
            this.buttonUrediZaposlenika.Text = "Uredi";
            this.buttonUrediZaposlenika.UseVisualStyleBackColor = false;
            this.buttonUrediZaposlenika.Click += new System.EventHandler(this.buttonUrediZaposlenika_Click);
            // 
            // buttonDodajZaposlenika
            // 
            this.buttonDodajZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonDodajZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajZaposlenika.FlatAppearance.BorderSize = 0;
            this.buttonDodajZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDodajZaposlenika.Location = new System.Drawing.Point(646, 292);
            this.buttonDodajZaposlenika.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDodajZaposlenika.Name = "buttonDodajZaposlenika";
            this.buttonDodajZaposlenika.Size = new System.Drawing.Size(139, 29);
            this.buttonDodajZaposlenika.TabIndex = 36;
            this.buttonDodajZaposlenika.Text = "Dodaj";
            this.buttonDodajZaposlenika.UseVisualStyleBackColor = false;
            this.buttonDodajZaposlenika.Click += new System.EventHandler(this.buttonDodajZaposlenika_Click);
            // 
            // buttonIzbrisiZaposlenika
            // 
            this.buttonIzbrisiZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIzbrisiZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonIzbrisiZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIzbrisiZaposlenika.FlatAppearance.BorderSize = 0;
            this.buttonIzbrisiZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIzbrisiZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzbrisiZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIzbrisiZaposlenika.Location = new System.Drawing.Point(335, 292);
            this.buttonIzbrisiZaposlenika.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIzbrisiZaposlenika.Name = "buttonIzbrisiZaposlenika";
            this.buttonIzbrisiZaposlenika.Size = new System.Drawing.Size(139, 29);
            this.buttonIzbrisiZaposlenika.TabIndex = 35;
            this.buttonIzbrisiZaposlenika.Text = "Izbriši";
            this.buttonIzbrisiZaposlenika.UseVisualStyleBackColor = false;
            this.buttonIzbrisiZaposlenika.Click += new System.EventHandler(this.buttonIzbrisiZaposlenika_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Zaposlenici:";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Location = new System.Drawing.Point(15, 56);
            this.dgvZaposlenici.Margin = new System.Windows.Forms.Padding(15);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.Size = new System.Drawing.Size(770, 227);
            this.dgvZaposlenici.TabIndex = 33;
            // 
            // PanelPocetna
            // 
            this.PanelPocetna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPocetna.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelPocetna.Controls.Add(this.label7);
            this.PanelPocetna.Controls.Add(this.LabelPrijavljeniKorisnik);
            this.PanelPocetna.Controls.Add(this.label6);
            this.PanelPocetna.Controls.Add(this.label5);
            this.PanelPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPocetna.Location = new System.Drawing.Point(184, 0);
            this.PanelPocetna.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPocetna.Name = "PanelPocetna";
            this.PanelPocetna.Size = new System.Drawing.Size(801, 461);
            this.PanelPocetna.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(132, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(612, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ukoliko vam je u nekom trenutku potrebna pomoć, možete je dobiti klikom na tipku " +
    "F1.\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(244, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trenutno ste prijavljeni kao ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dobrodošli u GymAdmin!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrijavljeniKorisnik
            // 
            this.LabelPrijavljeniKorisnik.AutoSize = true;
            this.LabelPrijavljeniKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrijavljeniKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrijavljeniKorisnik.ForeColor = System.Drawing.Color.Red;
            this.LabelPrijavljeniKorisnik.Location = new System.Drawing.Point(475, 138);
            this.LabelPrijavljeniKorisnik.Name = "LabelPrijavljeniKorisnik";
            this.LabelPrijavljeniKorisnik.Size = new System.Drawing.Size(0, 24);
            this.LabelPrijavljeniKorisnik.TabIndex = 2;
            this.LabelPrijavljeniKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GymAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelPocetna);
            this.Controls.Add(this.PanelZaposlenici);
            this.Controls.Add(this.PanelClanarine);
            this.Controls.Add(this.PanelKlijenti);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.PanelClanarine.ResumeLayout(false);
            this.PanelClanarine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanarine)).EndInit();
            this.PanelZaposlenici.ResumeLayout(false);
            this.PanelZaposlenici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.PanelPocetna.ResumeLayout(false);
            this.PanelPocetna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button BtnPocetna;
        private System.Windows.Forms.Button BtnClanarine;
        private System.Windows.Forms.Button BtnZaposlenici;
        private System.Windows.Forms.Button BtnKlijenti;
        private System.Windows.Forms.Panel PanelKlijenti;
        private System.Windows.Forms.Label LblKlijenti;
        private System.Windows.Forms.TextBox TxtPretrazivanjeKlijenti;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.Button BtnAzurirajKlijenti;
        private System.Windows.Forms.Button BtnIzbrisiKlijenti;
        private System.Windows.Forms.Button BtnDodajKlijenti;
        private System.Windows.Forms.Panel PanelActive;
        private System.Windows.Forms.Button BtnMjerenjaKlijenti;
        private System.Windows.Forms.Button buttonOsvjeziKlijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelClanarine;
        private System.Windows.Forms.TextBox TxtPretraziClanarine;
        private System.Windows.Forms.Label LblPretraziClanarine;
        private System.Windows.Forms.Button BtnOsvjeziClanarine;
        private System.Windows.Forms.DataGridView dgvClanarine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUrediClanarinu;
        private System.Windows.Forms.Button BtnIzbrisiClanarinu;
        private System.Windows.Forms.Button BtnDodajClanarinu;
        private System.Windows.Forms.Panel PanelZaposlenici;
        private System.Windows.Forms.Button BtnOzvjeziZaposlenici;
        private System.Windows.Forms.TextBox textBoxPretraga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUrediZaposlenika;
        private System.Windows.Forms.Button buttonDodajZaposlenika;
        private System.Windows.Forms.Button buttonIzbrisiZaposlenika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Panel PanelPocetna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnOdjava;
        private System.Windows.Forms.Label LabelPrijavljeniKorisnik;
    }
}

