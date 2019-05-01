using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    class Zaposlenik : Osoba
    {
        public int IdZaposlenika { get; set; }
        public string OIB { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public int IdVrstaZaposlenika { get; set; }
        public string VrstaZaposlenika { get; set; }
    }
}
