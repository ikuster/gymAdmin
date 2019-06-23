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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TPanelMjerenja = new System.Windows.Forms.TableLayoutPanel();
            this.PanelListaMjerenja = new System.Windows.Forms.Panel();
            this.BtnDodajMjerenja = new System.Windows.Forms.Button();
            this.BtnObrisiMjerenja = new System.Windows.Forms.Button();
            this.TxtPostotakMastiDodajMjerenje = new System.Windows.Forms.TextBox();
            this.TxtTežinaDodajMjerenje = new System.Windows.Forms.TextBox();
            this.TxtVisinaDodajMjerenje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMjerenja = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartTezina = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.chartVisina = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartMasnoce = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.TPanelMjerenja.SuspendLayout();
            this.PanelListaMjerenja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjerenja)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTezina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisina)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMasnoce)).BeginInit();
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
            this.TPanelMjerenja.Size = new System.Drawing.Size(954, 564);
            this.TPanelMjerenja.TabIndex = 0;
            // 
            // PanelListaMjerenja
            // 
            this.PanelListaMjerenja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelListaMjerenja.Controls.Add(this.BtnDodajMjerenja);
            this.PanelListaMjerenja.Controls.Add(this.BtnObrisiMjerenja);
            this.PanelListaMjerenja.Controls.Add(this.TxtPostotakMastiDodajMjerenje);
            this.PanelListaMjerenja.Controls.Add(this.TxtTežinaDodajMjerenje);
            this.PanelListaMjerenja.Controls.Add(this.TxtVisinaDodajMjerenje);
            this.PanelListaMjerenja.Controls.Add(this.label4);
            this.PanelListaMjerenja.Controls.Add(this.label3);
            this.PanelListaMjerenja.Controls.Add(this.label2);
            this.PanelListaMjerenja.Controls.Add(this.label1);
            this.PanelListaMjerenja.Controls.Add(this.dgvMjerenja);
            this.PanelListaMjerenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListaMjerenja.Location = new System.Drawing.Point(0, 0);
            this.PanelListaMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.PanelListaMjerenja.Name = "PanelListaMjerenja";
            this.PanelListaMjerenja.Size = new System.Drawing.Size(286, 564);
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
            this.BtnDodajMjerenja.Location = new System.Drawing.Point(152, 513);
            this.BtnDodajMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDodajMjerenja.Name = "BtnDodajMjerenja";
            this.BtnDodajMjerenja.Size = new System.Drawing.Size(117, 29);
            this.BtnDodajMjerenja.TabIndex = 26;
            this.BtnDodajMjerenja.Text = "Dodaj";
            this.BtnDodajMjerenja.UseVisualStyleBackColor = false;
            this.BtnDodajMjerenja.Click += new System.EventHandler(this.BtnDodajMjerenja_Click);
            // 
            // BtnObrisiMjerenja
            // 
            this.BtnObrisiMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnObrisiMjerenja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BtnObrisiMjerenja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnObrisiMjerenja.FlatAppearance.BorderSize = 0;
            this.BtnObrisiMjerenja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObrisiMjerenja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnObrisiMjerenja.Location = new System.Drawing.Point(14, 513);
            this.BtnObrisiMjerenja.Margin = new System.Windows.Forms.Padding(0);
            this.BtnObrisiMjerenja.Name = "BtnObrisiMjerenja";
            this.BtnObrisiMjerenja.Size = new System.Drawing.Size(117, 29);
            this.BtnObrisiMjerenja.TabIndex = 25;
            this.BtnObrisiMjerenja.Text = "Obriši";
            this.BtnObrisiMjerenja.UseVisualStyleBackColor = false;
            this.BtnObrisiMjerenja.Click += new System.EventHandler(this.BtnObrisiMjerenja_Click);
            // 
            // TxtPostotakMastiDodajMjerenje
            // 
            this.TxtPostotakMastiDodajMjerenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPostotakMastiDodajMjerenje.Location = new System.Drawing.Point(135, 420);
            this.TxtPostotakMastiDodajMjerenje.Name = "TxtPostotakMastiDodajMjerenje";
            this.TxtPostotakMastiDodajMjerenje.Size = new System.Drawing.Size(130, 26);
            this.TxtPostotakMastiDodajMjerenje.TabIndex = 7;
            // 
            // TxtTežinaDodajMjerenje
            // 
            this.TxtTežinaDodajMjerenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTežinaDodajMjerenje.Location = new System.Drawing.Point(135, 388);
            this.TxtTežinaDodajMjerenje.Name = "TxtTežinaDodajMjerenje";
            this.TxtTežinaDodajMjerenje.Size = new System.Drawing.Size(130, 26);
            this.TxtTežinaDodajMjerenje.TabIndex = 6;
            // 
            // TxtVisinaDodajMjerenje
            // 
            this.TxtVisinaDodajMjerenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVisinaDodajMjerenje.Location = new System.Drawing.Point(135, 356);
            this.TxtVisinaDodajMjerenje.Name = "TxtVisinaDodajMjerenje";
            this.TxtVisinaDodajMjerenje.Size = new System.Drawing.Size(130, 26);
            this.TxtVisinaDodajMjerenje.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Postotak masti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Težina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mjerenja:";
            // 
            // dgvMjerenja
            // 
            this.dgvMjerenja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjerenja.Location = new System.Drawing.Point(11, 33);
            this.dgvMjerenja.Name = "dgvMjerenja";
            this.dgvMjerenja.Size = new System.Drawing.Size(258, 291);
            this.dgvMjerenja.TabIndex = 0;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(286, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.90758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.09242F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 564);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.chartTezina);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.chartVisina);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 281);
            this.panel1.TabIndex = 0;
            // 
            // chartTezina
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTezina.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTezina.Legends.Add(legend1);
            this.chartTezina.Location = new System.Drawing.Point(345, 51);
            this.chartTezina.Name = "chartTezina";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTezina.Series.Add(series1);
            this.chartTezina.Size = new System.Drawing.Size(304, 227);
            this.chartTezina.TabIndex = 31;
            this.chartTezina.Text = "chartTezina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Težina";
            // 
            // chartVisina
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVisina.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVisina.Legends.Add(legend2);
            this.chartVisina.Location = new System.Drawing.Point(14, 54);
            this.chartVisina.Name = "chartVisina";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVisina.Series.Add(series2);
            this.chartVisina.Size = new System.Drawing.Size(311, 227);
            this.chartVisina.TabIndex = 29;
            this.chartVisina.Text = "chartVisina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Visina";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.chartMasnoce);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 281);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 283);
            this.panel3.TabIndex = 1;
            // 
            // chartMasnoce
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMasnoce.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartMasnoce.Legends.Add(legend3);
            this.chartMasnoce.Location = new System.Drawing.Point(16, 65);
            this.chartMasnoce.Name = "chartMasnoce";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartMasnoce.Series.Add(series3);
            this.chartMasnoce.Size = new System.Drawing.Size(633, 185);
            this.chartMasnoce.TabIndex = 31;
            this.chartMasnoce.Text = "chartMasnoce";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Postotak masnoće";
            // 
            // Mjerenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(954, 564);
            this.Controls.Add(this.TPanelMjerenja);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Mjerenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mjerenja";
            this.Load += new System.EventHandler(this.Mjerenja_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Mjerenja_HelpRequested);
            this.TPanelMjerenja.ResumeLayout(false);
            this.PanelListaMjerenja.ResumeLayout(false);
            this.PanelListaMjerenja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjerenja)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTezina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVisina)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMasnoce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TPanelMjerenja;
        private System.Windows.Forms.Panel PanelListaMjerenja;
        private System.Windows.Forms.DataGridView dgvMjerenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPostotakMastiDodajMjerenje;
        private System.Windows.Forms.TextBox TxtTežinaDodajMjerenje;
        private System.Windows.Forms.TextBox TxtVisinaDodajMjerenje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDodajMjerenja;
        private System.Windows.Forms.Button BtnObrisiMjerenja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisina;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMasnoce;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTezina;
        private System.Windows.Forms.Label label7;
    }
}