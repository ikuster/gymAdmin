using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymAdmin
{
    class ZaposlenikRadnje
    {
        private string GenerirajKorIme(Zaposlenik zaposlenik)
        {
            string korIme = zaposlenik.Ime[0] + zaposlenik.Prezime;
            korIme = korIme.ToLower();
            return korIme;
        }
        private string GenerirajLozinku()
        {
            string lozinka=System.Web.Security.Membership.GeneratePassword(7, 1);
            return lozinka;

        }
        private int ProvjeriPrijeDodavanja(string OIB)
        {
            int upitPostoji;
            using (var baza=new Entities())
            {
                upitPostoji = (from z in baza.Zaposlenik
                               where z.OIB == OIB
                               select z).Count();
            }
            return upitPostoji;
        }
        public int Autoriziraj(string korIme,string lozinka)
        {
            int provjeriPostojanje;
            using (var baza = new Entities())
            {
                provjeriPostojanje = (from z in baza.Zaposlenik
                                      where z.Korisnicko_ime == korIme
                                      && z.Lozinka == lozinka
                                      select z).Count();
            }
            return provjeriPostojanje;
        }
        public int VratiTipKorisnika(string korIme)
        {
            int tipKorisnika;
            using (var baza = new Entities())
            {
               tipKorisnika  =      (from z in baza.Zaposlenik
                                    where z.Korisnicko_ime == korIme
                                    select z.Vrsta_zaposlenika.Id_VrstaZaposlenika).First();
            }
            return tipKorisnika;

        }

        public List<Zaposlenik> DohvatiSveIzBaze()
        {
            List<Zaposlenik> zaposlenici;
            using(var baza = new Entities())
            {
                var upitDohvati = from z in baza.Zaposlenik
                                  select z;
                zaposlenici = upitDohvati.ToList();
            }
            return zaposlenici;

        }
        public void IzbrisiIzBaze(Zaposlenik odabraniZaposlenik)
        {
            using(var baza = new Entities())
            {
                baza.Zaposlenik.Attach(odabraniZaposlenik);
                baza.Zaposlenik.Remove(odabraniZaposlenik);
                baza.SaveChanges();
            }
        }
        public void UrediUBazi(Zaposlenik odabraniZaposlenik,Zaposlenik izmjene) {
            using(var context = new Entities())
            {
                context.Zaposlenik.Attach(odabraniZaposlenik);
                odabraniZaposlenik.Ime = izmjene.Ime;
                odabraniZaposlenik.Prezime = izmjene.Prezime;
                odabraniZaposlenik.Spol = izmjene.Spol;
                odabraniZaposlenik.Email = izmjene.Email;
                odabraniZaposlenik.Broj_mobitela = izmjene.Broj_mobitela;
                odabraniZaposlenik.OIB = izmjene.OIB;
                odabraniZaposlenik.Datum_zaposlenja = izmjene.Datum_zaposlenja;
                context.SaveChanges();
            }
            
        }
        public List<string> KreirajKredencijale(Zaposlenik noviZaposlenik) {
            List<string> kredencijali = new List<string>();
            string korIme = GenerirajKorIme(noviZaposlenik);
            string lozinka = GenerirajLozinku();
            kredencijali.Add(korIme);
            kredencijali.Add(lozinka);
            return kredencijali;
        }
        public bool DodajUBazu(Zaposlenik noviZaposlenik)
        {
            bool vecPostoji = false;
            string lozinka = GenerirajHash(noviZaposlenik.Lozinka);
            

            using(var baza = new Entities())
            {
                if (ProvjeriPrijeDodavanja(noviZaposlenik.OIB)==0) {

                    Zaposlenik zaposlenik = new Zaposlenik
                    {
                        Ime = noviZaposlenik.Ime,
                        Prezime = noviZaposlenik.Prezime,
                        Korisnicko_ime = noviZaposlenik.Korisnicko_ime,
                        Lozinka = lozinka,
                        Spol = noviZaposlenik.Spol,
                        Email = noviZaposlenik.Email,
                        Broj_mobitela = noviZaposlenik.Broj_mobitela,
                        OIB = noviZaposlenik.OIB,
                        Datum_zaposlenja = noviZaposlenik.Datum_zaposlenja,
                        Id_VrstaZaposlenika = noviZaposlenik.Id_VrstaZaposlenika
                    };
                    baza.Zaposlenik.Add(zaposlenik);
                    baza.SaveChanges();
                    return vecPostoji;
                }
                else
                {
                    vecPostoji = true;
                    return vecPostoji;
                }
            }
        }

        public List<Zaposlenik> PretraziZaposlenike(string ime)
        {
            List<Zaposlenik> zaposlenici;

            using (var context = new Entities())
            {
                var upit = from z in context.Zaposlenik
                           where z.Ime.Contains(ime)
                           select z;
                zaposlenici = upit.ToList();
            }
            return zaposlenici;
        }

        public string GenerirajHash(string lozinka)
        {
            
            if (string.IsNullOrEmpty(lozinka))
                   return string.Empty;

                using (var sha = new System.Security.Cryptography.SHA256Managed())
                {
                    byte[] tekst = Encoding.UTF8.GetBytes(lozinka);
                    byte[] hash = sha.ComputeHash(tekst);
                    return BitConverter.ToString(hash).Replace("-", string.Empty);
                }
            
        }
    }
}
