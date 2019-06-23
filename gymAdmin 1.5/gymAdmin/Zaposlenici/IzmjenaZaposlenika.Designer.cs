namespace gymAdmin
{
    partial class IzmjenaZaposlenika
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxImeZaposlenik = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeZaposlenik = new System.Windows.Forms.TextBox();
            this.textBoxEmailZaposlenik = new System.Windows.Forms.TextBox();
            this.textBoxBrMobZaposlenik = new System.Windows.Forms.TextBox();
            this.textBoxOibZaposlenik = new System.Windows.Forms.TextBox();
            this.dateTimePickerZaposlenje = new System.Windows.Forms.DateTimePicker();
            this.radioButtonSpolM = new System.Windows.Forms.RadioButton();
            this.radioButtonSpolŽ = new System.Windows.Forms.RadioButton();
            this.buttonSpremiZaposlenika = new System.Windows.Forms.Button();
            this.groupBoxSpol = new System.Windows.Forms.GroupBox();
            this.groupBoxSpol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(55, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(55, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(55, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Broj mobitela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(55, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(55, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "OIB:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(55, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Datum zaposlenja:";
            // 
            // textBoxImeZaposlenik
            // 
            this.textBoxImeZaposlenik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxImeZaposlenik.Location = new System.Drawing.Point(167, 37);
            this.textBoxImeZaposlenik.Name = "textBoxImeZaposlenik";
            this.textBoxImeZaposlenik.Size = new System.Drawing.Size(130, 20);
            this.textBoxImeZaposlenik.TabIndex = 9;
            this.textBoxImeZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxImeZaposlenik_Validating);
            // 
            // textBoxPrezimeZaposlenik
            // 
            this.textBoxPrezimeZaposlenik.Location = new System.Drawing.Point(167, 72);
            this.textBoxPrezimeZaposlenik.Name = "textBoxPrezimeZaposlenik";
            this.textBoxPrezimeZaposlenik.Size = new System.Drawing.Size(130, 20);
            this.textBoxPrezimeZaposlenik.TabIndex = 10;
            this.textBoxPrezimeZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrezimeZaposlenik_Validating);
            // 
            // textBoxEmailZaposlenik
            // 
            this.textBoxEmailZaposlenik.Location = new System.Drawing.Point(167, 147);
            this.textBoxEmailZaposlenik.Name = "textBoxEmailZaposlenik";
            this.textBoxEmailZaposlenik.Size = new System.Drawing.Size(130, 20);
            this.textBoxEmailZaposlenik.TabIndex = 11;
            this.textBoxEmailZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmailZaposlenik_Validating);
            // 
            // textBoxBrMobZaposlenik
            // 
            this.textBoxBrMobZaposlenik.Location = new System.Drawing.Point(167, 191);
            this.textBoxBrMobZaposlenik.Name = "textBoxBrMobZaposlenik";
            this.textBoxBrMobZaposlenik.Size = new System.Drawing.Size(130, 20);
            this.textBoxBrMobZaposlenik.TabIndex = 12;
            this.textBoxBrMobZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBrMobZaposlenik_Validating);
            // 
            // textBoxOibZaposlenik
            // 
            this.textBoxOibZaposlenik.Location = new System.Drawing.Point(167, 232);
            this.textBoxOibZaposlenik.Name = "textBoxOibZaposlenik";
            this.textBoxOibZaposlenik.Size = new System.Drawing.Size(130, 20);
            this.textBoxOibZaposlenik.TabIndex = 13;
            this.textBoxOibZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOibZaposlenik_Validating);
            // 
            // dateTimePickerZaposlenje
            // 
            this.dateTimePickerZaposlenje.Location = new System.Drawing.Point(198, 273);
            this.dateTimePickerZaposlenje.Name = "dateTimePickerZaposlenje";
            this.dateTimePickerZaposlenje.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerZaposlenje.TabIndex = 14;
            // 
            // radioButtonSpolM
            // 
            this.radioButtonSpolM.AutoSize = true;
            this.radioButtonSpolM.Location = new System.Drawing.Point(9, 10);
            this.radioButtonSpolM.Name = "radioButtonSpolM";
            this.radioButtonSpolM.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSpolM.TabIndex = 15;
            this.radioButtonSpolM.TabStop = true;
            this.radioButtonSpolM.Text = "M";
            this.radioButtonSpolM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpolŽ
            // 
            this.radioButtonSpolŽ.AutoSize = true;
            this.radioButtonSpolŽ.Location = new System.Drawing.Point(49, 10);
            this.radioButtonSpolŽ.Name = "radioButtonSpolŽ";
            this.radioButtonSpolŽ.Size = new System.Drawing.Size(32, 17);
            this.radioButtonSpolŽ.TabIndex = 16;
            this.radioButtonSpolŽ.TabStop = true;
            this.radioButtonSpolŽ.Text = "Ž";
            this.radioButtonSpolŽ.UseVisualStyleBackColor = true;
            // 
            // buttonSpremiZaposlenika
            // 
            this.buttonSpremiZaposlenika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpremiZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonSpremiZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpremiZaposlenika.FlatAppearance.BorderSize = 0;
            this.buttonSpremiZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpremiZaposlenika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSpremiZaposlenika.Location = new System.Drawing.Point(335, 308);
            this.buttonSpremiZaposlenika.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSpremiZaposlenika.Name = "buttonSpremiZaposlenika";
            this.buttonSpremiZaposlenika.Size = new System.Drawing.Size(63, 29);
            this.buttonSpremiZaposlenika.TabIndex = 29;
            this.buttonSpremiZaposlenika.Text = "Spremi";
            this.buttonSpremiZaposlenika.UseVisualStyleBackColor = false;
            this.buttonSpremiZaposlenika.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // groupBoxSpol
            // 
            this.groupBoxSpol.Controls.Add(this.radioButtonSpolŽ);
            this.groupBoxSpol.Controls.Add(this.radioButtonSpolM);
            this.groupBoxSpol.Location = new System.Drawing.Point(167, 98);
            this.groupBoxSpol.Name = "groupBoxSpol";
            this.groupBoxSpol.Size = new System.Drawing.Size(130, 33);
            this.groupBoxSpol.TabIndex = 30;
            this.groupBoxSpol.TabStop = false;
            this.groupBoxSpol.Validating += new System.ComponentModel.CancelEventHandler(this.groupBoxSpol_Validating);
            // 
            // IzmjenaZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(438, 368);
            this.Controls.Add(this.groupBoxSpol);
            this.Controls.Add(this.buttonSpremiZaposlenika);
            this.Controls.Add(this.dateTimePickerZaposlenje);
            this.Controls.Add(this.textBoxOibZaposlenik);
            this.Controls.Add(this.textBoxBrMobZaposlenik);
            this.Controls.Add(this.textBoxEmailZaposlenik);
            this.Controls.Add(this.textBoxPrezimeZaposlenik);
            this.Controls.Add(this.textBoxImeZaposlenik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IzmjenaZaposlenika";
            this.Text = "Uredi zaposlenika";
            this.Load += new System.EventHandler(this.IzmjenaZaposlenika_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.IzmjenaZaposlenika_HelpRequested);
            this.groupBoxSpol.ResumeLayout(false);
            this.groupBoxSpol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxImeZaposlenik;
        private System.Windows.Forms.TextBox textBoxPrezimeZaposlenik;
        private System.Windows.Forms.TextBox textBoxEmailZaposlenik;
        private System.Windows.Forms.TextBox textBoxBrMobZaposlenik;
        private System.Windows.Forms.TextBox textBoxOibZaposlenik;
        private System.Windows.Forms.DateTimePicker dateTimePickerZaposlenje;
        private System.Windows.Forms.RadioButton radioButtonSpolM;
        private System.Windows.Forms.RadioButton radioButtonSpolŽ;
        private System.Windows.Forms.Button buttonSpremiZaposlenika;
        private System.Windows.Forms.GroupBox groupBoxSpol;
    }
}