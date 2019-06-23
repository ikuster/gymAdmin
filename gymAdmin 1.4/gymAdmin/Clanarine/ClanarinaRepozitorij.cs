using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymAdmin
{
    public class ClanarinaRepozitorij
    {

        public List<Clanarina> DohvatiClanarine()
        {
            List<Clanarina> clanarine;

            using (var db = new Entities())
            {
                var upit = from a in db.Clanarina
                                select a;

                clanarine = upit.ToList();
            }

            return clanarine;         
        }

        private bool ProvjeriPostojanje(string imeClanarine)
        {
            bool postoji = false;

            using(var db = new Entities())
            {
                postoji = (from clanarina in db.Clanarina
                            where imeClanarine.Equals(clanarina.Naziv)
                            select clanarina).Any();
            }

            return postoji;
        }

        public void DodajClanarinu(Clanarina clanarina)
        {
            if (!ProvjeriPostojanje(clanarina.Naziv))
            {
                using (var db = new Entities())
                {
                    db.Clanarina.Add(clanarina);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Clanarina sa nazivom: " + clanarina.Naziv + " već postoji!");
            }
        }

        public void UrediClanarinu(Clanarina oldClanarina, Clanarina newClanarina)
        {
            using (var db = new Entities())
            {
                db.Clanarina.Attach(oldClanarina);
                oldClanarina.Naziv = newClanarina.Naziv;
                oldClanarina.Trajanje = newClanarina.Trajanje;
                oldClanarina.Cijena = newClanarina.Cijena;
                oldClanarina.Opis = newClanarina.Opis;
                db.SaveChanges();
            }
        }

        public void ObrisiClanarinu(Clanarina clanarina)
        {
            using (var db = new Entities())
            {
                db.Clanarina.Attach(clanarina);
                db.Clanarina.Remove(clanarina);
                db.SaveChanges();
            }
            
        }

        public List<Clanarina> PretraziClanarinu(string ime)
        {
            List<Clanarina> clanarine;

            using (var db = new Entities())
            {
                var upit = from a in db.Clanarina
                           where a.Naziv.Contains(ime)
                           select a;
                clanarine = upit.ToList();
            }
            return clanarine;
        }

        public bool ValidirajTrajanje(string trajanje)
        {
            if(int.TryParse(trajanje, out int t))
            {
                return true;
            }
            else if(trajanje == "")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool ValidirajCijenu(string cijena)
        {
            if (float.TryParse(cijena, out float c))
            {
                return true;
            }
            else if(cijena == "")
            {
                return false;
            }
            else
            {
                return false;
            }
        }

    }
}
