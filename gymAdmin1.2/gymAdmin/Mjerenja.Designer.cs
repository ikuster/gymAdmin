namespace gymAdmin
{
    partial class Mjerenja
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
            this.TPanelMjerenja = new System.Windows.Forms.TableLayoutPanel();
            this.PanelListaMjerenja = new System.Windows.Forms.Panel();
            this.BtnDodajMjerenja = new System.Windows.Forms.Button();
            this.BtnObrisiMjerenja = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGWMjerenja = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CboxMjerenjaTop = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CboxMjerenjaBottom = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TPanelMjerenja.SuspendLayout();
            this.PanelListaMjerenja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWMjerenja)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TPanelMjerenja
            // 
            this.TPanelMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TPanelMjerenja.ColumnCount = 2;
            this.TPanelMjerenja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TPanelMjerenja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TPanelMjerenja.Controls.Add(this.PanelListaMjerenja, 0, 0);
            this.TPanelMjerenja.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.TPanelMjerenja.Location = new System.Drawing.Point(-1, 0);
            this.TPanelMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.TPanelMjerenja.Name = "TPanelMjerenja";
            this.TPanelMjerenja.RowCount = 1;
            this.TPanelMjerenja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TPanelMjerenja.Size = new System.Drawing.Size(984, 461);
            this.TPanelMjerenja.TabIndex = 0;
            // 
            // PanelListaMjerenja
            // 
            this.PanelListaMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelListaMjerenja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelListaMjerenja.Controls.Add(this.BtnDodajMjerenja);
            this.PanelListaMjerenja.Controls.Add(this.BtnObrisiMjerenja);
            this.PanelListaMjerenja.Controls.Add(this.textBox3);
            this.PanelListaMjerenja.Controls.Add(this.textBox2);
            this.PanelListaMjerenja.Controls.Add(this.textBox1);
            this.PanelListaMjerenja.Controls.Add(this.label4);
            this.PanelListaMjerenja.Controls.Add(this.label3);
            this.PanelListaMjerenja.Controls.Add(this.label2);
            this.PanelListaMjerenja.Controls.Add(this.label1);
            this.PanelListaMjerenja.Controls.Add(this.DGWMjerenja);
            this.PanelListaMjerenja.Location = new System.Drawing.Point(0, 0);
            this.PanelListaMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.PanelListaMjerenja.Name = "PanelListaMjerenja";
            this.PanelListaMjerenja.Size = new System.Drawing.Size(295, 461);
            this.PanelListaMjerenja.TabIndex = 0;
            // 
            // BtnDodajMjerenja
            // 
            this.BtnDodajMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDodajMjerenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnDodajMjerenja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDodajMjerenja.FlatAppearance.BorderSize = 0;
            this.BtnDodajMjerenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDodajMjerenja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDodajMjerenja.Location = new System.Drawing.Point(163, 421);
            this.BtnDodajMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDodajMjerenja.Name = "BtnDodajMjerenja";
            this.BtnDodajMjerenja.Size = new System.Drawing.Size(117, 29);
            this.BtnDodajMjerenja.TabIndex = 26;
            this.BtnDodajMjerenja.Text = "Dodaj";
            this.BtnDodajMjerenja.UseVisualStyleBackColor = false;
            // 
            // BtnObrisiMjerenja
            // 
            this.BtnObrisiMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnObrisiMjerenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnObrisiMjerenja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnObrisiMjerenja.FlatAppearance.BorderSize = 0;
            this.BtnObrisiMjerenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObrisiMjerenja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnObrisiMjerenja.Location = new System.Drawing.Point(11, 422);
            this.BtnObrisiMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.BtnObrisiMjerenja.Name = "BtnObrisiMjerenja";
            this.BtnObrisiMjerenja.Size = new System.Drawing.Size(117, 29);
            this.BtnObrisiMjerenja.TabIndex = 25;
            this.BtnObrisiMjerenja.Text = "Obriši";
            this.BtnObrisiMjerenja.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 376);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 29);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 29);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postotak masti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Težina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mjerenja:";
            // 
            // DGWMjerenja
            // 
            this.DGWMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGWMjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWMjerenja.Location = new System.Drawing.Point(13, 33);
            this.DGWMjerenja.Name = "DGWMjerenja";
            this.DGWMjerenja.Size = new System.Drawing.Size(267, 260);
            this.DGWMjerenja.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(295, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 461);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.CboxMjerenjaTop);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 276);
            this.panel1.TabIndex = 0;
            // 
            // CboxMjerenjaTop
            // 
            this.CboxMjerenjaTop.FormattingEnabled = true;
            this.CboxMjerenjaTop.Location = new System.Drawing.Point(61, 12);
            this.CboxMjerenjaTop.Name = "CboxMjerenjaTop";
            this.CboxMjerenjaTop.Size = new System.Drawing.Size(228, 29);
            this.CboxMjerenjaTop.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Graf:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(16, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(15, 35, 15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 203);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.CboxMjerenjaBottom);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 276);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 185);
            this.panel3.TabIndex = 1;
            // 
            // CboxMjerenjaBottom
            // 
            this.CboxMjerenjaBottom.FormattingEnabled = true;
            this.CboxMjerenjaBottom.Location = new System.Drawing.Point(61, 1);
            this.CboxMjerenjaBottom.Name = "CboxMjerenjaBottom";
            this.CboxMjerenjaBottom.Size = new System.Drawing.Size(228, 29);
            this.CboxMjerenjaBottom.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(15, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(15, 35, 15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(658, 135);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Graf:";
            // 
            // Mjerenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.TPanelMjerenja);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Mjerenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mjerenja";
            this.TPanelMjerenja.ResumeLayout(false);
            this.PanelListaMjerenja.ResumeLayout(false);
            this.PanelListaMjerenja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWMjerenja)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TPanelMjerenja;
        private System.Windows.Forms.Panel PanelListaMjerenja;
        private System.Windows.Forms.DataGridView DGWMjerenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDodajMjerenja;
        private System.Windows.Forms.Button BtnObrisiMjerenja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CboxMjerenjaTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CboxMjerenjaBottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
    }
}