using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    public class Clanarina
    {
        public int IdClanarina { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public float Cijena { get; set; }
        public int Trajanje { get; set; }

        public Clanarina(string naziv, string opis, float cijena, int trajanje)
        {
            this.Naziv = naziv;
            this.Opis = opis;
            this.Cijena = cijena;
            this.Trajanje = trajanje;
        }
    }
}
