﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymAdmin
{
    public partial class GymAdmin : Form
    {
       
        public GymAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void TableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPocetna_MouseHover(object sender, EventArgs e)
        {

        }

        private void PanelZaposlenici_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnZaposlenici_Click(object sender, EventArgs e)
        {
            PanelActive.Location = new System.Drawing.Point(174, 276);
        }

        private void BtnKlijenti_Click(object sender, EventArgs e)
        {
            PanelKlijenti.BringToFront();
            PanelActive.Location = new System.Drawing.Point(174, 69);
        }

        private void BtnPocetna_Click(object sender, EventArgs e)
        {
            PanelActive.Location = new System.Drawing.Point(174, 0);
        }

        private void BtnClanarine_Click(object sender, EventArgs e)
        {
            PanelActive.Location = new System.Drawing.Point(174, 138);
        }

        private void BtnMjerenja_Click(object sender, EventArgs e)
        {
            PanelActive.Location = new System.Drawing.Point(174, 207);
        }

        private void BtnDodajKlijenti_Click(object sender, EventArgs e)
        {
            NoviClan noviClan = new NoviClan();
            noviClan.Show();
        }

        private void BtnIzbrisiKlijenti_Click(object sender, EventArgs e)
        {
            PotvrdaBrisanja formaBrisanje = new PotvrdaBrisanja();
            formaBrisanje.Show();
        }

        private void BtnMjerenjaKlijenti_Click(object sender, EventArgs e)
        {
            Mjerenja formMjerenja = new Mjerenja();
            formMjerenja.Show();
        }

        private void BtnDetaljnoKlijenti_Click(object sender, EventArgs e)
        {
            DetaljiKlijent formaDetaljiKlijent = new DetaljiKlijent();
            formaDetaljiKlijent.Show();
        }
    }
} 
