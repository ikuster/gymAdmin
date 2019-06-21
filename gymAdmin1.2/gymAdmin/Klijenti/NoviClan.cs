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
    public partial class NoviClan : Form
    {
        KlijentiRepozitorij Klijenti = new KlijentiRepozitorij();
        public NoviClan()
        {
            InitializeComponent();
        }

        private void BtnOdustaniNoviClan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Klijent kreirajNovogKlijenta()
        {
            Klijent noviKlijent = new Klijent();

            Clanarina clanarina = CboxVrstaClanarineNoviClan.SelectedItem as Clanarina;

            noviKlijent.Ime = TboxImeNoviClan.Text;
            noviKlijent.Prezime = TboxPrezimeNoviClan.Text;
            noviKlijent.Broj_mobitela = TboxTelefonNoviClan.Text;
            noviKlijent.Email = TboxEmailNoviClan.Text;
            noviKlijent.Spol = RBMuskiNoviClan.Checked ? "M" : "Ž";
            noviKlijent.Datum_isteka_clanarine = izracunajIstek(clanarina);
            noviKlijent.Datum_uclanjenja = DateTime.Now;
            noviKlijent.Id_Clanarina = clanarina.Id_Clanarina;

            return noviKlijent;
        }
        private DateTime izracunajIstek(Clanarina clanarina)
        {
            DateTime danas = DateTime.Now;
            return danas.AddDays(clanarina.Trajanje);
        }

        private void CboxVrstaClanarineNoviClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clanarina clanarina = CboxVrstaClanarineNoviClan.SelectedItem as Clanarina;
            LblIstekClanarineNoviClan.Text = izracunajIstek(clanarina).ToString("d/M/yy");
        }

        private void NoviClan_Load(object sender, EventArgs e)
        {
            ClanarinaRepozitorij clanarine = new ClanarinaRepozitorij();
            CboxVrstaClanarineNoviClan.DataSource = clanarine.DohvatiClanarine();
            CboxVrstaClanarineNoviClan.DisplayMember = "Naziv";

            LblDatumUclanjenjaNoviClan.Text = DateTime.Now.ToString("d/M/yy");
            Clanarina clanarina = CboxVrstaClanarineNoviClan.SelectedItem as Clanarina;
            LblIstekClanarineNoviClan.Text = izracunajIstek(clanarina).ToString("d/M/yy");
        }

        private void BtnDodajNoviClan_Click(object sender, EventArgs e)
        {
            Klijenti.DodajNovog(kreirajNovogKlijenta());
            this.Close();
        }
    }
}
