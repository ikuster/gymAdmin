namespace gymAdmin
{
    partial class NoviZaposlenik
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
            this.buttonDodajZaposlenika2 = new System.Windows.Forms.Button();
            this.groupBoxSpol = new System.Windows.Forms.GroupBox();
            this.BtnOdustaniNoviZaposlenik = new System.Windows.Forms.Button();
            this.groupBoxSpol.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Broj mobitela:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "OIB:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Datum zaposlenja:";
            // 
            // textBoxImeZaposlenik
            // 
            this.textBoxImeZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeZaposlenik.Location = new System.Drawing.Point(154, 9);
            this.textBoxImeZaposlenik.Name = "textBoxImeZaposlenik";
            this.textBoxImeZaposlenik.Size = new System.Drawing.Size(168, 26);
            this.textBoxImeZaposlenik.TabIndex = 9;
            this.textBoxImeZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxImeZaposlenik_Validating);
            // 
            // textBoxPrezimeZaposlenik
            // 
            this.textBoxPrezimeZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrezimeZaposlenik.Location = new System.Drawing.Point(154, 40);
            this.textBoxPrezimeZaposlenik.Name = "textBoxPrezimeZaposlenik";
            this.textBoxPrezimeZaposlenik.Size = new System.Drawing.Size(168, 26);
            this.textBoxPrezimeZaposlenik.TabIndex = 10;
            this.textBoxPrezimeZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrezimeZaposlenik_Validating);
            // 
            // textBoxEmailZaposlenik
            // 
            this.textBoxEmailZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailZaposlenik.Location = new System.Drawing.Point(-13, 9);
            this.textBoxEmailZaposlenik.Name = "textBoxEmailZaposlenik";
            this.textBoxEmailZaposlenik.Size = new System.Drawing.Size(168, 26);
            this.textBoxEmailZaposlenik.TabIndex = 11;
            this.textBoxEmailZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmailZaposlenik_Validating);
            // 
            // textBoxBrMobZaposlenik
            // 
            this.textBoxBrMobZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrMobZaposlenik.Location = new System.Drawing.Point(154, 144);
            this.textBoxBrMobZaposlenik.Name = "textBoxBrMobZaposlenik";
            this.textBoxBrMobZaposlenik.Size = new System.Drawing.Size(168, 26);
            this.textBoxBrMobZaposlenik.TabIndex = 12;
            this.textBoxBrMobZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBrMobZaposlenik_Validating);
            // 
            // textBoxOibZaposlenik
            // 
            this.textBoxOibZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOibZaposlenik.Location = new System.Drawing.Point(154, 178);
            this.textBoxOibZaposlenik.Name = "textBoxOibZaposlenik";
            this.textBoxOibZaposlenik.Size = new System.Drawing.Size(168, 26);
            this.textBoxOibZaposlenik.TabIndex = 13;
            this.textBoxOibZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOibZaposlenik_Validating);
            // 
            // dateTimePickerZaposlenje
            // 
            this.dateTimePickerZaposlenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerZaposlenje.Location = new System.Drawing.Point(154, 210);
            this.dateTimePickerZaposlenje.Name = "dateTimePickerZaposlenje";
            this.dateTimePickerZaposlenje.Size = new System.Drawing.Size(168, 26);
            this.dateTimePickerZaposlenje.TabIndex = 14;
            // 
            // radioButtonSpolM
            // 
            this.radioButtonSpolM.AutoSize = true;
            this.radioButtonSpolM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSpolM.Location = new System.Drawing.Point(154, 73);
            this.radioButtonSpolM.Name = "radioButtonSpolM";
            this.radioButtonSpolM.Size = new System.Drawing.Size(68, 24);
            this.radioButtonSpolM.TabIndex = 15;
            this.radioButtonSpolM.TabStop = true;
            this.radioButtonSpolM.Text = "Muški";
            this.radioButtonSpolM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpolŽ
            // 
            this.radioButtonSpolŽ.AutoSize = true;
            this.radioButtonSpolŽ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSpolŽ.Location = new System.Drawing.Point(231, 73);
            this.radioButtonSpolŽ.Name = "radioButtonSpolŽ";
            this.radioButtonSpolŽ.Size = new System.Drawing.Size(74, 24);
            this.radioButtonSpolŽ.TabIndex = 16;
            this.radioButtonSpolŽ.TabStop = true;
            this.radioButtonSpolŽ.Text = "Ženski";
            this.radioButtonSpolŽ.UseVisualStyleBackColor = true;
            // 
            // buttonDodajZaposlenika2
            // 
            this.buttonDodajZaposlenika2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodajZaposlenika2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.buttonDodajZaposlenika2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajZaposlenika2.FlatAppearance.BorderSize = 0;
            this.buttonDodajZaposlenika2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodajZaposlenika2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajZaposlenika2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDodajZaposlenika2.Location = new System.Drawing.Point(197, 265);
            this.buttonDodajZaposlenika2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDodajZaposlenika2.Name = "buttonDodajZaposlenika2";
            this.buttonDodajZaposlenika2.Size = new System.Drawing.Size(125, 29);
            this.buttonDodajZaposlenika2.TabIndex = 29;
            this.buttonDodajZaposlenika2.Text = "Dodaj";
            this.buttonDodajZaposlenika2.UseVisualStyleBackColor = false;
            this.buttonDodajZaposlenika2.Click += new System.EventHandler(this.buttonDodajZaposlenika2_Click);
            // 
            // groupBoxSpol
            // 
            this.groupBoxSpol.Controls.Add(this.textBoxEmailZaposlenik);
            this.groupBoxSpol.Location = new System.Drawing.Point(167, 98);
            this.groupBoxSpol.Name = "groupBoxSpol";
            this.groupBoxSpol.Size = new System.Drawing.Size(130, 33);
            this.groupBoxSpol.TabIndex = 30;
            this.groupBoxSpol.TabStop = false;
            this.groupBoxSpol.Validating += new System.ComponentModel.CancelEventHandler(this.groupBoxSpol_Validating);
            // 
            // BtnOdustaniNoviZaposlenik
            // 
            this.BtnOdustaniNoviZaposlenik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOdustaniNoviZaposlenik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnOdustaniNoviZaposlenik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOdustaniNoviZaposlenik.FlatAppearance.BorderSize = 0;
            this.BtnOdustaniNoviZaposlenik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOdustaniNoviZaposlenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOdustaniNoviZaposlenik.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnOdustaniNoviZaposlenik.Location = new System.Drawing.Point(16, 265);
            this.BtnOdustaniNoviZaposlenik.Margin = new System.Windows.Forms.Padding(0);
            this.BtnOdustaniNoviZaposlenik.Name = "BtnOdustaniNoviZaposlenik";
            this.BtnOdustaniNoviZaposlenik.Size = new System.Drawing.Size(125, 29);
            this.BtnOdustaniNoviZaposlenik.TabIndex = 31;
            this.BtnOdustaniNoviZaposlenik.Text = "Odustani";
            this.BtnOdustaniNoviZaposlenik.UseVisualStyleBackColor = false;
            this.BtnOdustaniNoviZaposlenik.Click += new System.EventHandler(this.BtnOdustaniNoviZaposlenik_Click);
            // 
            // NoviZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(334, 307);
            this.Controls.Add(this.BtnOdustaniNoviZaposlenik);
            this.Controls.Add(this.radioButtonSpolŽ);
            this.Controls.Add(this.groupBoxSpol);
            this.Controls.Add(this.radioButtonSpolM);
            this.Controls.Add(this.buttonDodajZaposlenika2);
            this.Controls.Add(this.dateTimePickerZaposlenje);
            this.Controls.Add(this.textBoxOibZaposlenik);
            this.Controls.Add(this.textBoxBrMobZaposlenik);
            this.Controls.Add(this.textBoxPrezimeZaposlenik);
            this.Controls.Add(this.textBoxImeZaposlenik);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoviZaposlenik";
            this.Text = "NoviZaposlenik";
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
        private System.Windows.Forms.Button buttonDodajZaposlenika2;
        private System.Windows.Forms.GroupBox groupBoxSpol;
        private System.Windows.Forms.Button BtnOdustaniNoviZaposlenik;
    }
}