using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    public class Klijent : Osoba
    {
        public int IdKlijent { get; set; }
        public DateTime VrijemeUclanjenja { get; set; }
        public Clanarina Clanarina { get; set; }
        public DateTime DatumIsteka { get; set; }
        public List<Mjerenje> Mjerenja { get; set; }

    }
}
