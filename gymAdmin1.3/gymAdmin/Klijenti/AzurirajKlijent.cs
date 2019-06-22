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
    public partial class AzurirajKlijent : Form
    {
        Klijent IzabraniKlijent;
        KlijentiRepozitorij Klijenti = new KlijentiRepozitorij();
        public AzurirajKlijent(Klijent izabraniKlijent)
        {
            InitializeComponent();
            IzabraniKlijent = izabraniKlijent;
        }

        private void BtnOdustaniDetaljiKlijent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AzurirajKlijent_Load(object sender, EventArgs e)
        {
            ClanarinaRepozitorij clanarine = new ClanarinaRepozitorij();
            List<Clanarina> sveClanarine = clanarine.DohvatiClanarine();
            comboBoxClanarina.DataSource = sveClanarine;
            comboBoxClanarina.DisplayMember = "Naziv";

            textBoxIme.Text = IzabraniKlijent.Ime;
            textBoxPrezime.Text = IzabraniKlijent.Prezime;
            rBMuski.Checked = IzabraniKlijent.Spol == "M" ? true : rBZenski.Checked = true;
            textBoxTelefon.Text = IzabraniKlijent.Broj_mobitela;
            textBoxEmail.Text = IzabraniKlijent.Email;
            labelDatumUclanjenja.Text = IzabraniKlijent.Datum_uclanjenja.ToString("d/M/yy");
            labelDatumIsteka.Text = IzabraniKlijent.Datum_isteka_clanarine.Value.ToString("d/M/yy");
        }

        private void BtnUrediDetaljiKlijent_Click(object sender, EventArgs e)
        {
            Klijent azuriraniKlijent = new Klijent();

            azuriraniKlijent.Ime = textBoxIme.Text;
            azuriraniKlijent.Prezime = textBoxPrezime.Text;
            azuriraniKlijent.Email = textBoxEmail.Text;
            azuriraniKlijent.Broj_mobitela = textBoxTelefon.Text;
            azuriraniKlijent.Spol = rBMuski.Checked ? "M" : "Ž";
            Clanarina novaClanarina = comboBoxClanarina.SelectedItem as Clanarina;
            azuriraniKlijent.Id_Clanarina = novaClanarina.Id_Clanarina;
            azuriraniKlijent.Datum_isteka_clanarine = DateTime.Now.AddDays(novaClanarina.Trajanje);

            Klijenti.AzurirajKlijenta(IzabraniKlijent, azuriraniKlijent);
            this.Close();
        }

        private void comboBoxClanarina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clanarina novaClanarina = comboBoxClanarina.SelectedItem as Clanarina;
            labelDatumIsteka.Text = DateTime.Now.AddDays(novaClanarina.Trajanje).ToString("d/M/yy");
        }

        private void textBoxIme_Validating(object sender, CancelEventArgs e)
        {
            string Ime = textBoxIme.Text;
            if (Ime.Length < 2 || Ime.Any(char.IsDigit) || Ime.Length > 12)
            {
                e.Cancel = true;
            }
        }

        private void textBoxPrezime_Validating(object sender, CancelEventArgs e)
        {
            string Prezime = textBoxPrezime.Text;
            if (Prezime.Length < 2 || Prezime.Any(char.IsDigit) || Prezime.Length > 12)
            {
                e.Cancel = true;
            }
        }

        private void textBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            string Broj = textBoxTelefon.Text;
            if (Broj.Length < 8 || Broj.Length > 14)
            {
                e.Cancel = true;
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = textBoxEmail.Text;
            if (Email.Length < 6 || Email.Length > 18)
            {
                e.Cancel = true;
            }
        }


    }
}
