using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Klinika
    {
        private List<Pacijent> pacijenti;
        private List<Karton> kartoni;
        private List<Uposleni> uposlenici;
        private List<Pregled> pregledi;
        

        public List<Pacijent> Pacijenti { get => pacijenti; set => pacijenti = value; }
        public List<Karton> Kartoni { get => kartoni; set => kartoni = value; }
        public List<Uposleni> Uposlenici { get => uposlenici; set => uposlenici = value; }
        public List<Pregled> Pregledi { get => pregledi; set => pregledi = value; }

        public Klinika()
        {
            Pacijenti = new List<Pacijent>();
            Kartoni = new List<Karton>();
            Uposlenici = new List<Uposleni>();
            Pregledi = new List<Pregled>();
        }
        //--PACIJENTI--/

        public void DodajPacijenta(Pacijent p)
        {
            Pacijenti.Add(p);
        }

        public void BrisiPacijenta(int i)
        {
            Pacijenti.RemoveAt(i - 1);
        }

       

        public Pacijent IspisiNajredovnijegPacijenta()
        {
            int br = 0;
            foreach (Karton k in Kartoni)
            {
                if (k.Pregledi.Count > br)
                    br = k.Pregledi.Count;
            }
            string jmbg = "";
            foreach (Karton k in Kartoni)
            {
                if (k.Pregledi.Count == br)
                    jmbg = k.JmbgPacijenta;
            }
            int rb = 0;
            foreach (Pacijent p in Pacijenti)
            {
                rb++;
                if (p.Jmbg == jmbg)
                {
                    break; 
                }
                rb++;
            }
            return Pacijenti[rb];
        }

        public int RedniBrojPacijenta(string jmbg)
        {
            int i = 0;

            foreach (Pacijent p in Pacijenti)
            {
                if (p.Jmbg == jmbg) return i;
                i++;
            }
            return 0;
        }

        public int DajBrojPacijenata()
        {
            return Pacijenti.Count;
        }

        public Pacijent DajPacijenta(int i)
        {
            return Pacijenti[i - 1];
        }

        //--UPOSLENI--//

        public void DodajUposlenog(Uposleni u)
        {
            Uposlenici.Add(u);
        }

        public void BrisiUposlenog(int u)
        {
            Uposlenici.RemoveAt(u - 1);
        }

        /*public void IspisiUposlene()
        {
            int i = 1;
            Console.WriteLine("Uposlenici:");
            foreach (Uposleni u in uposlenici)
            {
                Console.WriteLine("{0}. " + u.ToString(), i);
                i++;
            }
        }*/

        public Uposleni DajUposlenog(int i)
        {
            return Uposlenici[i];
        }

        public double ProsjecnaPlata()
        {
            double prosjek = 0;
            foreach (Uposleni u in Uposlenici)
            {
                prosjek += u.Plata;
            }
            prosjek = prosjek / Uposlenici.Count;
            return prosjek;
        }

        public Uposleni UposleniSaMaxPlatom()
        {
            double max = Uposlenici[0].Plata;
            foreach (Uposleni u in Uposlenici)
            {
                if (u.Plata > max) max = u.Plata;
            }
            foreach (Uposleni u in Uposlenici)
            {
                if (max == u.Plata) return u;
            }

            return Uposlenici[0];
        }

        public int DajBrojUposlenih()
        {
            return Uposlenici.Count;
        }

        //--PREGLEDI--//

        public void DodajPregled(Pregled pre)
        {
            Pregledi.Add(pre);
        }

        public double ZaPlatit(string jmbg)
        {
            double suma = 0;
            foreach (Pregled p in Pregledi)
            {
                suma = suma + p.Cijena;
            }
            return suma;
        }

        public double SumaSvihPregleda()
        {
            double suma = 0;
            foreach (Pregled p in Pregledi)
            {
                suma = suma + p.Cijena;
            }
            return suma;
        }

        public bool SlobodanTermin(DateTime datum, int terminSati)
        {
            foreach (Pregled p in Pregledi)
            {
                if (p.DanPregleda == datum && p.VrijemeSati == terminSati)
                {
                    Console.WriteLine("Termin je zauzet, ukucajte novi termin. ");
                    return false;
                }
            }
            return true;
        }

        public bool ImaLiPregleda(string jmbg)
        {
            foreach (Pregled p in Pregledi)
            {
                if (p.JmbgPacijenta == jmbg)
                    return true;
            }
            return false;
        }

        public void IspisiPregledeSaJMBG(string jmbg)
        {
            int i = 1;
            foreach (Pregled p in Pregledi)
            {
                if (p.JmbgPacijenta == jmbg)
                {
                    Console.WriteLine("{0}. " + p.ToString(), i);
                    i++;
                }
            }
        }
        public void IspisiPreglede()
        {
            int i = 1;
            Console.WriteLine("Pregledi: ");
            foreach (Pregled p in Pregledi)
            {
                Console.WriteLine("{0}. " + p.ToString(), i);
                i++;
            }
        }
        public void BrisiPregled(int k)
        {
            Pregledi.RemoveAt(k - 1);
        }
        public void ObrisiPregledeUMRLOG(string jmbg)
        {
            int i = 0;

            foreach (Pregled k in Pregledi)
            {
                if (k.JmbgPacijenta == jmbg)
                    BrisiPregled(i);

            }


        }



        //--KARTONI--//

        public void DodajKarton(Karton k)
        {
            Kartoni.Add(k);
        }

        public int BrojPregledaPacijenta(string jmbg)
        {
            foreach (Karton k in Kartoni)
            {
                if (k.JmbgPacijenta == jmbg)
                    return k.Pregledi.Count;
            }
            return 0;

        }

        public void IspisiKartonPoJMBG(string jmbg)
        {
            foreach (Karton k in Kartoni)
            {
                if (k.JmbgPacijenta == jmbg)
                    Console.WriteLine(k.ToString());


            }

        }

        public bool ImaLiVecKartonPoImenu(string ime)
        {
            foreach (Karton k in Kartoni)
            {
                if (k.Ime == ime)
                    return true;
            }
            return false;
        }
        public void IspisiKartonPoImenu(string ime)
        {
            foreach (Karton k in Kartoni)
            {
                if (k.Ime == ime)
                    Console.WriteLine(k.ToString());


            }

        }

        public bool ImaLiVecKartonPoPrezimenu(string prezime)
        {
            foreach (Karton k in Kartoni)
            {
                if (k.Prezime == prezime)
                    return true;
            }
            return false;
        }
        public void IspisiKartonPoPrezimenu(string prezime)
        {
            foreach (Karton k in Kartoni)
            {
                if (k.Prezime == prezime)
                    Console.WriteLine(k.ToString());


            }

        }


        public bool ImaLiVecKarton(string jmbg)
        {
            foreach (Karton k in Kartoni)
            {
                if (k.JmbgPacijenta == jmbg)
                    return true;
            }
            return false;
        }

        public void BrisiKarton(int k)
        {
            Kartoni.RemoveAt(k - 1);
        }

        public int RedniBrojKartonaUmrlog(string jmbg)
        {
            int i = 0;
            foreach (Karton k in Kartoni)
            {
                if (k.JmbgPacijenta == jmbg)
                    return i;
                i++;
            }
            return 0;
        }
        public void IspisiKartone()
        {
            int i = 1;
            Console.WriteLine("Kartoni:");
            foreach (Karton k in Kartoni)
            {
                Console.WriteLine("{0}. " + k.ToString(), i);
                i++;
            }
        }

        public int DajBrojKartona()
        {
            return Kartoni.Count;
        }

        public Karton DajKarton(int i)
        {
            return Kartoni[i - 1];
        }
    }
}
