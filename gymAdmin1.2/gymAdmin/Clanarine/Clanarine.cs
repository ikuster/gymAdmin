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
    public partial class Clanarine : Form
    {
        ClanarinaRepozitorij Repozitorij = new ClanarinaRepozitorij();

        public Clanarine()
        {
            InitializeComponent();
        }

        private Clanarina getClanarina()
        {
            return dgvClanarine.CurrentRow.DataBoundItem as Clanarina;
        }

        private void OsvjeziFormu()
        {
            dgvClanarine.DataSource = Repozitorij.DohvatiClanarine();
        }

        private void BtnDodajClanarinu_Click(object sender, EventArgs e)
        {
            NovaClanarina formaNovaClanarina = new NovaClanarina();
            formaNovaClanarina.ShowDialog();
        }

        private void Clanarine_Load(object sender, EventArgs e)
        {
            OsvjeziFormu();
            dgvClanarine.Columns[0].Visible = false;
        }

        private void BtnOsvjeziClanarine_Click(object sender, EventArgs e)
        {
            OsvjeziFormu();
        }

        private void BtnIzbrisiClanarinu_Click(object sender, EventArgs e)
        {
            Repozitorij.ObrisiClanarinu(getClanarina());
            OsvjeziFormu();
        }

        private void BtnUrediClanarinu_Click(object sender, EventArgs e)
        {
      
            UrediClanarinu formaUrediClanarinu = new UrediClanarinu();
            formaUrediClanarinu.MojaClanarina = getClanarina();
            formaUrediClanarinu.ShowDialog();
        }
    }
}
