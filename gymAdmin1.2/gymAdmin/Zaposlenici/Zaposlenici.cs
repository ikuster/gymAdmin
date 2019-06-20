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
    public partial class Zaposlenici : Form
    {
        ZaposlenikRadnje zaposlenici = new ZaposlenikRadnje();
        public Zaposlenici()
        {
            InitializeComponent();
        }
        private void OsvjeziFormu()
        {
            dgvZaposlenici.DataSource = zaposlenici.DohvatiSveIzBaze();
            dgvZaposlenici.Columns[4].Visible = false;
            dgvZaposlenici.Columns[10].Visible = false;
            dgvZaposlenici.Columns[11].Visible = false;
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            OsvjeziFormu();

        }

        private void buttonIzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            Zaposlenik odabraniZaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;
            if(MessageBox.Show("Jeste li sigurni?", "Upozorenje", MessageBoxButtons.YesNo) 
                == DialogResult.Yes)
            {
                zaposlenici.IzbrisiIzBaze(odabraniZaposlenik);
            }
            OsvjeziFormu();
        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            NoviZaposlenik formaNoviZaposlenik = new NoviZaposlenik();
            formaNoviZaposlenik.Show();
        }

        private void textBoxPretraga_TextChanged(object sender, EventArgs e)
        {
            using(var baza=new Entities())
            {
                var upitPretraga = from z in baza.Zaposlenik
                                   where z.Prezime.Contains(textBoxPretraga.Text) || 
                                   z.Ime.Contains(textBoxPretraga.Text)
                                   select z;
                dgvZaposlenici.DataSource = upitPretraga.ToList();
            }
            dgvZaposlenici.Columns[4].Visible = false;
            dgvZaposlenici.Columns[10].Visible = false;
            dgvZaposlenici.Columns[11].Visible = false;
        }

        private void buttonOsvježi_Click(object sender, EventArgs e)
        {
            OsvjeziFormu();
        }

        private void buttonUrediZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.CurrentRow != null)
            {
                Zaposlenik selektiraniZaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;
                if (selektiraniZaposlenik != null)
                {
                    IzmjenaZaposlenika formaIzmjenaZaposlenika = new IzmjenaZaposlenika(selektiraniZaposlenik);
                    formaIzmjenaZaposlenika.ShowDialog();
                }
            }

        }
    }
}
