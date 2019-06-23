using System;
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
    public partial class NovaClanarina : Form
    {
        ClanarinaRepozitorij Repozitorij = new ClanarinaRepozitorij();
        bool ispravniPodaci = false;

        public NovaClanarina()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.sport;

        }

        private Clanarina StvoriClanarinu()
        {
            Clanarina clanarina = new Clanarina
            {
                Naziv = TxtNazivNovaClanarina.Text.ToString(),
                Trajanje = int.Parse(TxtTrajanjeNovaClanarina.Text),
                Cijena = float.Parse(TxtCijenaNovaClanarina.Text),
                Opis = TxtOpisNovaClanarina.Text.ToString()
            };

            return clanarina;
        }

        private void BtnOdustaniNovaClanarina_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDodajNovaClanarina_Click(object sender, EventArgs e)
        {
            if (ispravniPodaci && TxtNazivNovaClanarina.Text != "")
            {
                Repozitorij.DodajClanarinu(StvoriClanarinu());
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaci nisu u ispravnom formatu!");
            }
            
            
        }

        private void NovaClanarina_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void NovaClanarina_Load(object sender, EventArgs e)
        {

        }

        private void TxtTrajanjeNovaClanarina_TextChanged(object sender, EventArgs e)
        {
            if (!Repozitorij.ValidirajTrajanje(TxtTrajanjeNovaClanarina.Text))
            {
                LabelValidation1.BackColor = Color.Red;
            }
            else
            {
                LabelValidation1.BackColor = Color.Green;
            }
        }

        private void TxtNazivNovaClanarina_TextChanged(object sender, EventArgs e)
        {
            if (TxtNazivNovaClanarina.Text != "")
            {
                LabelValidation0.BackColor = Color.Green;
                ispravniPodaci = true;
            }
            else
            {
                LabelValidation0.BackColor = Color.Red;
                ispravniPodaci = false;
            }
            
        }

        private void TxtCijenaNovaClanarina_TextChanged(object sender, EventArgs e)
        {
            if (!Repozitorij.ValidirajCijenu(TxtCijenaNovaClanarina.Text))
            {
                LabelValidation2.BackColor = Color.Red;
                ispravniPodaci = false;
            }
            else
            {
                LabelValidation2.BackColor = Color.Green;
                ispravniPodaci = true;
            }
        }


    }
}
