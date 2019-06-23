using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gymAdmin
{
    public partial class NoviClan : Form
    {
        KlijentiRepozitorij Klijenti = new KlijentiRepozitorij();
        public NoviClan()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.sport;
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

        private void TboxImeNoviClan_Validating(object sender, CancelEventArgs e)
        {
            string Ime = TboxImeNoviClan.Text;
            if (Ime.Length < 2 || Ime.Any(char.IsDigit) || Ime.Length > 50)
            {
                e.Cancel = true;
            }
        }

        private void TboxPrezimeNoviClan_Validating(object sender, CancelEventArgs e)
        {
            string Prezime = TboxPrezimeNoviClan.Text;
            if (Prezime.Length < 2 || Prezime.Any(char.IsDigit) || Prezime.Length > 50)
            {
                e.Cancel = true;
            }
        }

        private void TboxTelefonNoviClan_Validating(object sender, CancelEventArgs e)
        {
            string Broj = TboxTelefonNoviClan.Text;
            if (Broj.Length < 8 || Broj.Length > 50)
            {
                e.Cancel = true;
            }
        }

        private void TboxEmailNoviClan_Validating(object sender, CancelEventArgs e)
        {
            string Email = TboxEmailNoviClan.Text;
            if (Email.Length < 6 || Email.Length > 50)
            {
                e.Cancel = true;
            }
        }

        private void panel1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\helpNoviKlijent.html", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            Help.ShowHelp(this, FileName);
        }

        private void CboxVrstaClanarineNoviClan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clanarina clanarina = CboxVrstaClanarineNoviClan.SelectedItem as Clanarina;
            LblIstekClanarineNoviClan.Text = izracunajIstek(clanarina).ToString("d/M/yy");
        }
    }
}
