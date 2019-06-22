using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace gymAdmin
{
    public partial class Mjerenja : Form
    {
        public Klijent MojKlijent { get; set; }
        public MjerenjaRepozitorij MjerenjaRepozitorij = new MjerenjaRepozitorij();
        public string[] GrafOpcije = { "Visina", "Težina", "Postotak masnoće" };

        public Mjerenja()
        {
            InitializeComponent();
        }

        public void OsvjeziMjerenja()
        {
            dgvMjerenja.DataSource = MjerenjaRepozitorij.DohvatiMjerenja(MojKlijent);
            dgvMjerenja.Columns[0].Visible = false;
            dgvMjerenja.Columns[4].Visible = false;
            dgvMjerenja.Columns[6].Visible = false;

        }

        public void OcistiFormu()
        {
            TxtPostotakMastiDodajMjerenje.Clear();
            TxtTežinaDodajMjerenje.Clear();
            TxtVisinaDodajMjerenje.Clear();
        }

        public Mjerenje getMjerenje()
        {
            return dgvMjerenja.CurrentRow.DataBoundItem as Mjerenje;
        }
        private void UcitajGrafMasnoca(Chart chart)
        {
            var masnocaGraf = new Series("Postotak masnoće");

            List<Mjerenje> mjerenja = MjerenjaRepozitorij.DohvatiMjerenja(MojKlijent);

            double[] postotciMasnoce = new double[mjerenja.Count];
            int[] dani = new int[mjerenja.Count];

            mjerenja.ForEach(x => postotciMasnoce[mjerenja.IndexOf(x)] = x.Mast);
            mjerenja.ForEach(x => dani[mjerenja.IndexOf(x)] = mjerenja.IndexOf(x) + 1);
            masnocaGraf.Points.DataBindXY(dani, postotciMasnoce);
            chart.Series.Clear();
            chart.Series.Add(masnocaGraf);
        }
        private void UcitajGrafTezina(Chart chart)
        {
            OsvjeziMjerenja();
            var tezineGraf = new Series("Težina");

            List<Mjerenje> mjerenja = MjerenjaRepozitorij.DohvatiMjerenja(MojKlijent);

            double[] tezine = new double[mjerenja.Count];
            int[] dani = new int[mjerenja.Count];

            mjerenja.ForEach(x => dani[mjerenja.IndexOf(x)] = mjerenja.IndexOf(x) + 1);
            mjerenja.ForEach(x => tezine[mjerenja.IndexOf(x)] = x.Tezina);
            tezineGraf.Points.DataBindXY(dani, tezine);
            chart.Series.Clear();
            chart.Series.Add(tezineGraf);
        }
        private void UcitajGrafVisina(Chart chart)
        {
            OsvjeziMjerenja();
            var visineGraf = new Series("Visina");

            List<Mjerenje> mjerenja = MjerenjaRepozitorij.DohvatiMjerenja(MojKlijent);

            double[] visine = new double[mjerenja.Count];
            int[] dani = new int[mjerenja.Count];

            mjerenja.ForEach(x => dani[mjerenja.IndexOf(x)] = mjerenja.IndexOf(x) + 1);
            mjerenja.ForEach(x => visine[mjerenja.IndexOf(x)] = x.Visina);
            visineGraf.Points.DataBindXY(dani, visine);
            chart.Series.Clear();
            chart.Series.Add(visineGraf);
        }
        private void Mjerenja_Load(object sender, EventArgs e)
        {
            OsvjeziMjerenja();
            UcitajGrafMasnoca(chart1);
            UcitajGrafTezina(chart2);
            CboxMjerenjaTop.DataSource = GrafOpcije;
            CboxMjerenjaTop.SelectedItem = "Postotak masnoće";
            CboxMjerenjaBottom.BindingContext = new BindingContext();
            CboxMjerenjaBottom.DataSource = GrafOpcije;
            CboxMjerenjaBottom.SelectedItem = "Težina";
        }

        private Mjerenje StvoriMjerenje()
        {

            Mjerenje mjerenje = new Mjerenje
            {
                Visina = double.Parse(TxtVisinaDodajMjerenje.Text),
                Tezina = double.Parse(TxtTežinaDodajMjerenje.Text),
                Datum_mjerenja = DateTime.Now,
                Mast = double.Parse(TxtPostotakMastiDodajMjerenje.Text),
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

        private void BtnObrisiMjerenja_Click(object sender, EventArgs e)
        {
            MjerenjaRepozitorij.IzbrisiMjerenje(getMjerenje());
            OsvjeziMjerenja();
        }

        private void CboxMjerenjaTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izabranaOpcija = CboxMjerenjaTop.SelectedItem.ToString();
            switch (izabranaOpcija)
            {
                case "Visina":
                    UcitajGrafVisina(chart1);
                    break;
                case "Težina":
                    UcitajGrafTezina(chart1);
                    break;
                case "Postotak masnoće":
                    UcitajGrafMasnoca(chart1);
                    break;
            }
        }

        private void CboxMjerenjaBottom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izabranaOpcija = CboxMjerenjaBottom.SelectedItem.ToString();
            switch (izabranaOpcija)
            {
                case "Visina":
                    UcitajGrafVisina(chart2);
                    break;
                case "Težina":
                    UcitajGrafTezina(chart2);
                    break;
                case "Postotak masnoće":
                    UcitajGrafMasnoca(chart2);
                    break;
            }
        }
    }
    
}
