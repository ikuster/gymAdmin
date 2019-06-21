using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    public class KlijentiRepozitorij
    {
        public List<Klijent> DohvatiKlijente()
        {
            List<Klijent> klijenti;

            using (var db = new Entities())
            {
                var upit = from a in db.Klijent
                           select a;

                klijenti = upit.ToList();
            }

            return klijenti;
        }
        public void DodajNovog(Klijent klijent)
        {
            using (var db = new Entities())
            {
                db.Klijent.Add(klijent);
                db.SaveChanges();
            }
        }
        public void ObrisiKlijenta(Klijent klijent)
        {
            using (var db = new Entities())
            {
                db.Klijent.Attach(klijent);
                db.Klijent.Remove(klijent);
                db.SaveChanges();
            }

        }
        public void AzurirajKlijenta(Klijent klijent)
        {

        }
    }
}
