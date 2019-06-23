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
    public partial class IzmjenaZaposlenika : Form
    {
        ZaposlenikRadnje zaposlenici = new ZaposlenikRadnje();
        private Zaposlenik zaposlenikIzmjena;
        
        public IzmjenaZaposlenika(Zaposlenik odabraniZaposlenik)
        {
            zaposlenikIzmjena = odabraniZaposlenik;
            InitializeComponent();
            this.Icon = Properties.Resources.sport;
        }

        private void IzmjenaZaposlenika_Load(object sender, EventArgs e)
        {
            if (zaposlenikIzmjena != null)
            {
                textBoxImeZaposlenik.Text = zaposlenikIzmjena.Ime;
                textBoxPrezimeZaposlenik.Text = zaposlenikIzmjena.Prezime;
                groupBoxSpol.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Text == zaposlenikIzmjena.Spol).Checked=true;
                textBoxEmailZaposlenik.Text = zaposlenikIzmjena.Email;
                textBoxBrMobZaposlenik.Text = zaposlenikIzmjena.Broj_mobitela;
                textBoxOibZaposlenik.Text = zaposlenikIzmjena.OIB;
                dateTimePickerZaposlenje.Value = zaposlenikIzmjena.Datum_zaposlenja;
            }

        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
                Zaposlenik zaposlenik = new Zaposlenik();
                zaposlenik.Ime = textBoxImeZaposlenik.Text;           
                zaposlenik.Prezime = textBoxPrezimeZaposlenik.Text;
                var checkedButton = groupBoxSpol.Controls.OfType<RadioButton>()
                                         .FirstOrDefault(rb => rb.Checked);
                zaposlenik.Spol = checkedButton.Text;
                zaposlenik.Email = textBoxEmailZaposlenik.Text;
                zaposlenik.Broj_mobitela = textBoxBrMobZaposlenik.Text;
                zaposlenik.OIB = textBoxOibZaposlenik.Text;
                zaposlenik.Datum_zaposlenja = dateTimePickerZaposlenje.Value;
                zaposlenici.UrediUBazi(zaposlenikIzmjena,zaposlenik);
                MessageBox.Show("Uspješno ste izmijenili podatke o zaposleniku!");
                this.Hide();
            
        }

        private void textBoxImeZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            string Ime = textBoxImeZaposlenik.Text;
            if (Ime.Length < 3 || Ime.Any(char.IsDigit) || Ime.Length > 12)
            {
                e.Cancel = true;

            }
        }

        private void textBoxPrezimeZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            string Prezime = textBoxPrezimeZaposlenik.Text;
            if (Prezime.Length < 3 || Prezime.Any(char.IsDigit) || Prezime.Length > 12)
            {
                e.Cancel = true;
            }
        }

        private void groupBoxSpol_Validating(object sender, CancelEventArgs e)
        {

            if (groupBoxSpol.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked) == null)
            {
                e.Cancel = true;
            }
        }

        private void textBoxEmailZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            string email = textBoxEmailZaposlenik.Text;
            if (email.Length < 5 || !email.Contains("@"))
            {
                e.Cancel = true;
            }
        }

        private void textBoxBrMobZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            string brMob = textBoxBrMobZaposlenik.Text;
            if (brMob.Length < 9 || brMob.Any(char.IsLetter) || brMob.Any(char.IsSymbol) || brMob.Length > 11)
            {
                e.Cancel = true;
            }
        }

        private void textBoxOibZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            string OIB = textBoxOibZaposlenik.Text;
            if (OIB.Length != 11 || OIB.Any(char.IsLetter) || OIB.Any(char.IsSymbol))
            {
                e.Cancel = true;
            }
        }

    }
}
