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
    public partial class GymAdmin : Form
    {
        private string korIme;
        KlijentiRepozitorij Klijenti = new KlijentiRepozitorij();
        ZaposlenikRadnje Zaposlenici = new ZaposlenikRadnje();
        ClanarinaRepozitorij Clanarine = new ClanarinaRepozitorij();

        public GymAdmin(string korisnickoIme)
        {
            korIme = korisnickoIme;
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelPrijavljeniKorisnik.Text = korIme;
            PanelPocetna.BringToFront();
            PanelActive.Location = new System.Drawing.Point(174, 0);
        }

        //NAVIGACIJA

        private void BtnZaposlenici_Click(object sender, EventArgs e)
        {
            
            
            if (Zaposlenici.VratiTipKorisnika(korIme) == 2) {
                OsvjeziZaposlenike();
                PanelZaposlenici.BringToFront();
                PanelActive.Location = new System.Drawing.Point(174, 207);
            }
            else
            {
                MessageBox.Show("Nemate prava!");
            }
        }

        private void BtnKlijenti_Click(object sender, EventArgs e)
        {
            OsvjeziKlijente();
            PanelKlijenti.BringToFront();
            PanelActive.Location = new System.Drawing.Point(174, 69);
        }

        private void BtnPocetna_Click(object sender, EventArgs e)
        {
            PanelPocetna.BringToFront();
            PanelActive.Location = new System.Drawing.Point(174, 0);
        }

        private void BtnClanarine_Click(object sender, EventArgs e)
        {
            OsvjeziClanarine();
            PanelClanarine.BringToFront();
            PanelActive.Location = new System.Drawing.Point(174, 138);
        }

        //KLIJENTI PANEL

        private void OsvjeziKlijente()
        {
            dgvKlijenti.DataSource = Klijenti.DohvatiKlijente();
            dgvKlijenti.Columns[9].Visible = false;
            dgvKlijenti.Columns[10].Visible = false;
        }

        private void BtnDodajKlijenti_Click(object sender, EventArgs e)
        {
            NoviClan noviClan = new NoviClan();
            noviClan.Show();
        }

        private void NoviClan_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnIzbrisiKlijenti_Click(object sender, EventArgs e)
        {
            Klijent izabraniKlijent = dgvKlijenti.CurrentRow.DataBoundItem as Klijent;
            Klijenti.ObrisiKlijenta(izabraniKlijent);
            OsvjeziKlijente();
        }

        private void BtnMjerenjaKlijenti_Click(object sender, EventArgs e)
        {
            Mjerenja formMjerenja = new Mjerenja();
            formMjerenja.MojKlijent = getKlijent();
            formMjerenja.Show();
        }

        private void BtnAzurirajKlijenti_Click(object sender, EventArgs e)
        {
            Klijent izabraniKlijent = dgvKlijenti.CurrentRow.DataBoundItem as Klijent;
            AzurirajKlijent azurirajKlijent = new AzurirajKlijent(izabraniKlijent);
            azurirajKlijent.Show();
        }

        private void buttonOsvjeziKlijenti_Click(object sender, EventArgs e)
        {
            OsvjeziKlijente();
        }

        private void TxtPretrazivanjeKlijenti_TextChanged(object sender, EventArgs e)
        {
            dgvKlijenti.DataSource = Klijenti.DohvatiKlijente().Where(x => x.Ime.Contains(TxtPretrazivanjeKlijenti.Text)).ToList();
        }
        private Klijent getKlijent()
        {
            return dgvKlijenti.CurrentRow.DataBoundItem as Klijent;
        }

        //CLANARINE PANEL      

        private Clanarina getClanarina()
        {
            return dgvClanarine.CurrentRow.DataBoundItem as Clanarina;
        }

        private void OsvjeziClanarine()
        {
            dgvClanarine.DataSource = Clanarine.DohvatiClanarine();
        }

        private void BtnOsvjeziClanarine_Click(object sender, EventArgs e)
        {
            OsvjeziClanarine();
        }

        private void BtnIzbrisiClanarinu_Click(object sender, EventArgs e)
        {
            Clanarine.ObrisiClanarinu(getClanarina());
            OsvjeziClanarine();
        }

        private void BtnUrediClanarinu_Click(object sender, EventArgs e)
        {
            UrediClanarinu formaUrediClanarinu = new UrediClanarinu();
            formaUrediClanarinu.MojaClanarina = getClanarina();
            formaUrediClanarinu.ShowDialog();
        }

        private void BtnDodajClanarinu_Click(object sender, EventArgs e)
        {
            NovaClanarina formaNovaClanarina = new NovaClanarina();
            formaNovaClanarina.ShowDialog();
        }

        private void TxtPretraziClanarine_TextChanged(object sender, EventArgs e)
        {
            dgvClanarine.DataSource = Clanarine.PretraziClanarinu(TxtPretraziClanarine.Text);
        }


        //ZAPOSLENICI PANEL

        ZaposlenikRadnje zaposlenici = new ZaposlenikRadnje();

        private void OsvjeziZaposlenike()
        {
            dgvZaposlenici.DataSource = zaposlenici.DohvatiSveIzBaze();
            dgvZaposlenici.Columns[4].Visible = false;
            dgvZaposlenici.Columns[10].Visible = false;
            dgvZaposlenici.Columns[11].Visible = false;
        }

        private void textBoxPretraga_TextChanged(object sender, EventArgs e)
        {
            using (var baza = new Entities())
            {
                var upitPretraga = from z in baza.Zaposlenik
                                   where z.Prezime.Contains(textBoxPretraga.Text) ||
                                   z.Ime.Contains(textBoxPretraga.Text)
                                   select z;
                dgvZaposlenici.DataSource = upitPretraga.ToList();
            }
            dgvZaposlenici.Columns[4].Visible = false;
            dgvZaposlenici.Columns[10].Visible = false;
            dgvZaposlenici.Columns[11].Visible = false;
        }

        private void BtnOzvjeziZaposlenici_Click(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }

        private void buttonIzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            Zaposlenik odabraniZaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;
            if (MessageBox.Show("Jeste li sigurni?", "Upozorenje", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                zaposlenici.IzbrisiIzBaze(odabraniZaposlenik);
            }
            OsvjeziZaposlenike();
        }

        private void buttonUrediZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.CurrentRow != null)
            {
                Zaposlenik selektiraniZaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as Zaposlenik;
                if (selektiraniZaposlenik != null)
                {
                    IzmjenaZaposlenika formaIzmjenaZaposlenika = new IzmjenaZaposlenika(selektiraniZaposlenik);
                    formaIzmjenaZaposlenika.ShowDialog();
                }
            }
        }

        private void buttonDodajZaposlenika_Click(object sender, EventArgs e)
        {
            NoviZaposlenik formaNoviZaposlenik = new NoviZaposlenik();
            formaNoviZaposlenik.Show();
        }


    }
}
