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
    public partial class UrediClanarinu : Form
    {

        public Clanarina MojaClanarina { get; set; }
        ClanarinaRepozitorij Repozitorij = new ClanarinaRepozitorij();
        bool ispravniPodaci = false;

        public UrediClanarinu()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.sport;
        }

        private void BtnDodajUrediClanarinu_Click(object sender, EventArgs e)
        {

            if (ispravniPodaci && TxtNazivUrediClanarinu.Text != "")
            {
                Clanarina c = new Clanarina
                {
                    Naziv = TxtNazivUrediClanarinu.Text.ToString(),
                    Trajanje = int.Parse(TxtTrajanjeUrediClanarinu.Text),
                    Cijena = float.Parse(TxtCijenaUrediClanarinu.Text),
                    Opis = TxtOpisUrediClanarinu.Text.ToString()
                };

                Repozitorij.UrediClanarinu(MojaClanarina, c);
                this.Close();
            }
            else
            {
                MessageBox.Show("Podaci nisu u ispravnom formatu!");
            }
            
        }

        private void BtnOdustaniUrediClanarinu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UrediClanarinu_Load_1(object sender, EventArgs e)
        {
            TxtNazivUrediClanarinu.Text = MojaClanarina.Naziv.ToString();
            TxtTrajanjeUrediClanarinu.Text = MojaClanarina.Trajanje.ToString();
            TxtCijenaUrediClanarinu.Text = MojaClanarina.Cijena.ToString();
            TxtOpisUrediClanarinu.Text = MojaClanarina.Opis.ToString();
        }
    }
}
