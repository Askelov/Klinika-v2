﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NMK
{
    public sealed class Doktor : Uposleni //jedna klasa mora bit sealed
    {
        private string specijalizacija;
        private static double bonusNaPlatu;
        private int brPacijenata;

        private string username;
        private string password;
        private Image slika;

        public Doktor(string pime, string pprezime, string pjmbg, string padresa, string pspol, string pbracnoStanje, DateTime pdatumRodenja, string psifra, double pplata, string ppozicija, string pspecijalizacija, int pbrPacijenata) : base(pime, pprezime, pjmbg, padresa, pspol, pbracnoStanje, pdatumRodenja, psifra, pplata, ppozicija)
        {
            Specijalizacija = pspecijalizacija;

            BrPacijenata = pbrPacijenata;
        }
        public double BonusNaPlatu { get; set; }
        public string Specijalizacija
        {
            get
            {
                return specijalizacija;
            }

            set
            {
                specijalizacija = value;
            }
        }

        public int BrPacijenata
        {
            get
            {
                return brPacijenata;
            }

            set
            {
                brPacijenata = value;
            }
        }

        public string Username2 { get => username; set => username = value; }
        public string Password2 { get => password; set => password = value; }
        public Image Slika2 { get => slika; set => slika = value; }

        public override string ToString()
        {
            string s = "";
            s += Ime.ToString() + " " + Prezime.ToString() + "\nJMBG: " + Jmbg.ToString() + "\nAdresa stanovanja:  " + Adresa.ToString() + "\nSpol: " + Spol.ToString() + "\nBracno stanje: " + BracnoStanje.ToString() + "\nDatum rodjenja: " + DatumRodjenja.Date.ToString("d") + "\nSifra: " + Sifra.ToString() + "\nPlata: " + Plata.ToString() + "\nPozicija: " + Pozicija.ToString() + "\nSpecijalizacija: " + specijalizacija.ToString() + "\nBonus na platu: " + BonusNaPlatu.ToString() + "\nBroj pacijenata: " + BrPacijenata.ToString() + "\n";
            return s;
        }

    }
}
