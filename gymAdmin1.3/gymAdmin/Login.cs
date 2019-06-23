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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.sport;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZaposlenikRadnje zaposlenik = new ZaposlenikRadnje();
            string hashLozinka = zaposlenik.GenerirajHash(textBoxLozinka.Text);
            int provjeriPostojanje = zaposlenik.Autoriziraj(textBoxKorIme.Text, hashLozinka);

            if (provjeriPostojanje == 1)
            {
                this.Hide();
                string korIme = textBoxKorIme.Text;
                GymAdmin glavnaForma = new GymAdmin(korIme);
                glavnaForma.Show();
            }

            else
            {
                MessageBox.Show("Unijeli ste pogrešno korisničko ime ili lozinku!");
                textBoxKorIme.Clear();
                textBoxLozinka.Clear();
            }

        }


    }
}
