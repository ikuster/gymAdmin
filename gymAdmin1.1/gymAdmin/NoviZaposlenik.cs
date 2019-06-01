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
    public partial class NoviZaposlenik : Form
    {
        ZaposlenikRadnje zaposlenici = new ZaposlenikRadnje();
        public NoviZaposlenik()
        {
            InitializeComponent();
        }
        private bool ProvjeriUnos()
        {
            if (textBoxImeZaposlenik.Text == "" || textBoxPrezimeZaposlenik.Text == "" ||
                textBoxEmailZaposlenik.Text == "" || textBoxBrMobZaposlenik.Text == "" || textBoxOibZaposlenik.Text == "" ||
                (groupBoxSpol.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked) == null)) return false;
            else return true;
        }

        private void buttonDodajZaposlenika2_Click(object sender, EventArgs e)
        {
            if (ProvjeriUnos()) {
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
                zaposlenici.DodajUBazu(zaposlenik);
                MessageBox.Show($"Uspješno dodan član! Korisničko ime člana je:{zaposlenik.Korisnicko_ime},a lozinka je:" +
                    $"{zaposlenik.Lozinka} ," +
                    $"najbolje da odmah zapišete Vaše podatke za prijavu!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sva polja moraju biti unesena!");
            }
            
            
            

        }
    }
}
