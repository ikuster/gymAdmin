using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Spol { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string BrojMobitela { get; set; }
    }
}
