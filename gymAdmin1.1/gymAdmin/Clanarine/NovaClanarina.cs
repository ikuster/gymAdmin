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

        public NovaClanarina()
        {
            InitializeComponent();
            
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
            Repozitorij.DodajClanarinu(StvoriClanarinu());
            this.Close();
        }

        private void NovaClanarina_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
