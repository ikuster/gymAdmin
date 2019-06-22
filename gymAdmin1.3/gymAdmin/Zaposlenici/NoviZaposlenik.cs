using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace gymAdmin
{
    public partial class NoviZaposlenik : Form
    {
        ZaposlenikRadnje zaposlenici = new ZaposlenikRadnje();
        
        public NoviZaposlenik()
        {
            InitializeComponent();
        }

        private void buttonDodajZaposlenika2_Click(object sender, EventArgs e)
        {           
                List<string> kredencijali = new List<string>();
                var checkedButton = groupBoxSpol.Controls.OfType<RadioButton>()
                                          .FirstOrDefault(rb => rb.Checked);
                Zaposlenik zaposlenik = new Zaposlenik();
                zaposlenik.Ime = textBoxImeZaposlenik.Text;
                zaposlenik.Prezime = textBoxPrezimeZaposlenik.Text;
                kredencijali = zaposlenici.KreirajKredencijale(zaposlenik);
                zaposlenik.Korisnicko_ime = kredencijali[0];
                zaposlenik.Lozinka = kredencijali[1];
                zaposlenik.Spol = checkedButton.Text;
                zaposlenik.Email = textBoxEmailZaposlenik.Text;
                zaposlenik.Broj_mobitela = textBoxBrMobZaposlenik.Text;
                zaposlenik.OIB = textBoxOibZaposlenik.Text;
                zaposlenik.Datum_zaposlenja = dateTimePickerZaposlenje.Value;
                zaposlenik.Id_VrstaZaposlenika = 1;
                if (zaposlenici.DodajUBazu(zaposlenik) == false)
                {
                    MessageBox.Show($"Uspješno dodan zaposlenik! Korisničko ime zaposlenika je: {zaposlenik.Korisnicko_ime}, a lozinka je: " +
                    $"{zaposlenik.Lozinka} ," +
                    $" najbolje da odmah zapišete Vaše podatke za prijavu!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Taj zaposlenik već postoji u bazi!");
                }
            }
            
            
            
        
        private void textBoxImeZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            string Ime = textBoxImeZaposlenik.Text;
            if (Ime.Length < 3 || Ime.Any(char.IsDigit) || Ime.Length > 12)
            {
                e.Cancel=true;

            }
        }

        private void textBoxPrezimeZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            string Prezime = textBoxPrezimeZaposlenik.Text;
            if (Prezime.Length < 3 || Prezime.Any(char.IsDigit) || Prezime.Length > 12)
            {
                e.Cancel = true;
                textBoxPrezimeZaposlenik.BackColor = Color.Red;
            }
        }

        private void groupBoxSpol_Validating(object sender, CancelEventArgs e)
        {

            if(groupBoxSpol.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked) == null)
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
            if (OIB.Length !=11 || OIB.Any(char.IsLetter) || OIB.Any(char.IsSymbol))
            {
                e.Cancel = true;
            }
        }
    }
}
