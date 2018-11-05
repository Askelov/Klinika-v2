using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace NMK
{
    public class Uposleni : Osoba
    {
        private string sifra;
        private double plata;
        private string pozicija;

        private string username;
        private string password;
        private Image slika;

        public Uposleni(string pime, string pprezime, string pjmbg, string padresa, string pspol, string pbracnoStanje, DateTime pdatumRodenja, string psifra, double pplata, string ppozicija) : base(pime, pprezime, pjmbg, padresa, pspol, pbracnoStanje, pdatumRodenja)
        {
            Sifra = psifra;
            Plata = pplata;
            Pozicija = ppozicija;
        }

        public string Sifra
        {
            get
            {
                return sifra;
            }

            set
            {
                sifra = value;
            }
        }

        public string Pozicija
        {
            get
            {
                return pozicija;
            }

            set
            {
                pozicija = value;
            }
        }

        public double Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }

        public string Username { get => Username1; set => Username1 = value; }
        public string Password { get => Password1; set => Password1 = value; }
        public Image Slika { get => Slika1; set => Slika1 = value; }
        public string Username1 { get => username; set => username = value; }
        public string Password1 { get => password; set => password = value; }
        public Image Slika1 { get => slika; set => slika = value; }

        public override string ToString()
        {
            string s = "";
            s += Ime.ToString() + " " + Prezime.ToString() + "\nJMBG: " + Jmbg.ToString() + "\nAdresa stanovanja:  " + Adresa.ToString() + "\nSpol: " + Spol.ToString() + "\nBracno stanje: " + BracnoStanje.ToString() + "\nDatum rodjenja: " + DatumRodjenja.Date.ToString("d") + "\nSifra: " + Sifra.ToString() + "\nPlata: " + Plata.ToString() + "\nPozicija: " + Pozicija.ToString() + "\n";
            return s;
        }


    }
}
