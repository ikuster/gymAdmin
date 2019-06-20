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
            using (var context = new Entities())
            {
                context.Zaposlenik.Attach(zaposlenikIzmjena);
                zaposlenikIzmjena.Prezime = textBoxPrezimeZaposlenik.Text;
                zaposlenikIzmjena.Email = textBoxEmailZaposlenik.Text;
                zaposlenikIzmjena.Broj_mobitela = textBoxBrMobZaposlenik.Text;
                context.SaveChanges();
                MessageBox.Show("Uspješno ste izmijenili podatke o zaposleniku!");
               this.Hide();
            }
        }

    }
}
