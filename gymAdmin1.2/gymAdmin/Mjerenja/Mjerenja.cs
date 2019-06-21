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
    public partial class Mjerenja : Form
    {
        public Klijent MojKlijent { get; set; }
        public MjerenjaRepozitorij MjerenjaRepozitorij = new MjerenjaRepozitorij();
       

        public Mjerenja()
        {
            InitializeComponent();
        }

        public void OsvjeziMjerenja()
        {
            dgvMjerenja.DataSource = MjerenjaRepozitorij.DohvatiMjerenja(MojKlijent);
            dgvMjerenja.Columns[0].Visible = false;
            dgvMjerenja.Columns[4].Visible = false;
            dgvMjerenja.Columns[5].Visible = false;
        }

        public void OcistiFormu()
        {
            TxtPostotakMastiDodajMjerenje.Clear();
            TxtTežinaDodajMjerenje.Clear();
            TxtVisinaDodajMjerenje.Clear();
        }
 
        private void Mjerenja_Load(object sender, EventArgs e)
        {
            OsvjeziMjerenja();
        }

        private Mjerenje StvoriMjerenje()
        {

            Mjerenje mjerenje = new Mjerenje
            {
                Visina = double.Parse(TxtVisinaDodajMjerenje.Text),
                Tezina = double.Parse(TxtTežinaDodajMjerenje.Text),
                Datum_mjerenja = DateTime.Now,
                Id_Klijent = MojKlijent.Id_Klijent
            };

            return mjerenje;
        
        }

        private void BtnDodajMjerenja_Click(object sender, EventArgs e)
        {
            MjerenjaRepozitorij.DodajMjerenje(StvoriMjerenje());
            OcistiFormu();
            OsvjeziMjerenja();
        }
    }
}
