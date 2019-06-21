using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    public class MjerenjaRepozitorij
    {

        public List<Mjerenje> DohvatiMjerenja(Klijent klijent)
        {
            List<Mjerenje> mjerenja;

            using (var db = new Entities())
            {
                var m = from a in db.Mjerenje
                        where a.Id_Klijent == klijent.Id_Klijent
                        select a;
                mjerenja = m.ToList();

            }
            return mjerenja;
        }

        public void DodajMjerenje(Mjerenje mjerenje) 
        {
            using (var db = new Entities())
            {
                db.Mjerenje.Add(mjerenje);
                db.SaveChanges();
            }
        }
    }
}
