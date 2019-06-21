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
        KlijentiRepozitorij Klijenti = new KlijentiRepozitorij();
        public GymAdmin()
        {
            InitializeComponent();
        }
        private void OsvjeziFormu()
        {
            dgvKlijenti.DataSource = Klijenti.DohvatiKlijente();
            dgvKlijenti.Columns[9].Visible = false;
            dgvKlijenti.Columns[10].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OsvjeziFormu();
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

            Zaposlenici formaZaposlenici = new Zaposlenici();
            formaZaposlenici.Show();
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

        private void NoviClan_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnIzbrisiKlijenti_Click(object sender, EventArgs e)
        {
            Klijent izabraniKlijent = dgvKlijenti.CurrentRow.DataBoundItem as Klijent;
            Klijenti.ObrisiKlijenta(izabraniKlijent);
            OsvjeziFormu();
        }

        private void BtnMjerenjaKlijenti_Click(object sender, EventArgs e)
        {
            Mjerenja formMjerenja = new Mjerenja();
            formMjerenja.MojKlijent = getKlijent(); 
            formMjerenja.Show();
        }

        private void BtnDetaljnoKlijenti_Click(object sender, EventArgs e)
        {
            DetaljiKlijent formaDetaljiKlijent = new DetaljiKlijent();
            formaDetaljiKlijent.Show();
        }

        private void BtnPretraziKlijenti_Click(object sender, EventArgs e)
        {
            OsvjeziFormu();
        }

        private Klijent getKlijent()
        {
            return dgvKlijenti.CurrentRow.DataBoundItem as Klijent;
        }
    }
}