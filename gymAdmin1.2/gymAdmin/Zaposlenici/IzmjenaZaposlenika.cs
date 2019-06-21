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
        }
        private bool ProvjeriUnos()
        {
            if (textBoxImeZaposlenik.Text == "" || textBoxPrezimeZaposlenik.Text == "" ||
                textBoxEmailZaposlenik.Text == "" || textBoxBrMobZaposlenik.Text == "" || textBoxOibZaposlenik.Text == "" ||
                (groupBoxSpol.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked) == null)) return false;
            else return true;
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
                if (ProvjeriUnos())
                    {
                        zaposlenici.UrediUBazi(zaposlenikIzmjena,zaposlenik);
                        MessageBox.Show("Uspješno ste izmijenili podatke o zaposleniku!");
                        this.Hide();
                    }
                else MessageBox.Show("Sva polja moraju biti popunjena!");
            
        }

    }
}
