using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;

namespace NMK
{
    public class Pacijent : Osoba
    {
        private DateTime prijem;
        
        private string username;
        private string password;
        private Image slika;

        public string hash(string pass)
        {
            MD5CryptoServiceProvider kodiraj = new MD5CryptoServiceProvider();
            kodiraj.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] niz = kodiraj.Hash;
            StringBuilder pom = new StringBuilder();
            for (int i = 0; i < niz.Length; i++) pom.Append(niz[i].ToString("x2"));

            return pom.ToString();
        }
        public Pacijent(string pime, string pprezime, string pjmbg, string padresa, string pspol, string pbracnoStanje, DateTime pdatumRodenja, DateTime pprijem) : base(pime, pprezime, pjmbg, padresa, pspol, pbracnoStanje, pdatumRodenja)
        {
            prijem = pprijem;
        }

        public Pacijent(Pacijent p) : base(p.Ime, p.Prezime, p.Jmbg, p.Adresa, p.Spol, p.BracnoStanje, p.DatumRodjenja)
        {
            Prijem = p.Prijem;
        }

        public DateTime Prijem
        {
            get
            {
                return prijem;
            }

            set
            {
                prijem = value;
            }
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Image Slika { get => slika; set => slika = value; }

        public override string ToString()
        {
            string s = "";
            s += "\n" + Ime.ToString() + " " + Prezime.ToString() + "\nJMBG: " + Jmbg.ToString() + "\nAdresa stanovanja:  " + Adresa.ToString() + "\nSpol: " + Spol.ToString() + "\nBracno stanje: " + BracnoStanje.ToString() + "\nDatum rodjenja: " + DatumRodjenja.Date.ToString("d") + "\n";
            return s;
        }


    }
}
