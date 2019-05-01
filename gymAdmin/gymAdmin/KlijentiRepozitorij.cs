using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    class KlijentiRepozitorij
    {
        public static List<Klijent> Klijenti {get; set;}
        public void DodajNovog(Klijent klijent)
        {
            Klijenti.Add(klijent);
        }
        public void IzbrisiKlijenta(Klijent klijent)
        {
            Klijenti.Remove(klijent);
        }
        public void AzurirajKlijenta(Klijent klijent)
        {
            
        }
    }
}
