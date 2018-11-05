using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NMK
{
    public partial class Form1 : Form
    {
        public static Klinika k = new Klinika();

        public string hash(string pass)
        {
            MD5CryptoServiceProvider kodiraj = new MD5CryptoServiceProvider();
            kodiraj.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pass));
            byte[] niz = kodiraj.Hash;
            StringBuilder pom = new StringBuilder();
            for (int i = 0; i < niz.Length; i++) pom.Append(niz[i].ToString("x2"));

            return pom.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics mojGrafickiObjekat;
            mojGrafickiObjekat = this.CreateGraphics();

            Pen mojPen = new Pen(System.Drawing.Color.Red, 5);
            SolidBrush mojBrush = new SolidBrush(System.Drawing.Color.Red);

            Point[] polygonTacke = new Point[5]; // Definisanje niza tačaka

            polygonTacke[0] = new Point(73, 220);
            polygonTacke[1] = new Point(30, 93);
            polygonTacke[2] = new Point(140, 7);
            polygonTacke[3] = new Point(253, 93);
            polygonTacke[4] = new Point(210, 220);

            Pen moj = new Pen(System.Drawing.Color.White, 20);
            Rectangle elipsaPravougaonik = new Rectangle(23, 10, 236, 235);
            mojGrafickiObjekat.DrawEllipse(moj, elipsaPravougaonik);

            mojGrafickiObjekat.DrawPolygon(mojPen, polygonTacke); // Crtanje poligona
            mojGrafickiObjekat.DrawLines(mojPen, polygonTacke); // Crtanje linija
            mojGrafickiObjekat.FillPolygon(mojBrush, polygonTacke); // Crtanje 
            mojGrafickiObjekat.DrawString("+", new Font("Monospaced", 200, FontStyle.Bold), new SolidBrush(Color.White), 15, -30);
            mojGrafickiObjekat.DrawString("NMK", new Font("Monospaced", 20, FontStyle.Bold), new SolidBrush(Color.White), 103, 190);







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void prijava_Click(object sender, EventArgs e)
        {


            if (username.Text == "admin" && password.Text == "admin")
            {
                Admin a = new Admin();
                a.Show();
                username.Text = "";
                password.Text = "";

                //this.Hide();
            }
            else if (username.Text == "uposleni" && password.Text == "uposleni")
            {
                UposleniForma uf = new UposleniForma();
                uf.Show();
                username.Text = "";
                password.Text = "";

                //this.Hide();
            }
            else if (username.Text == "doktor" && password.Text == "doktor")
            {
                DoktorForm df = new DoktorForm();
                df.Show();
                username.Text = "";
                password.Text = "";

                //this.Hide();
            }
            else if (username.Text == "pacijent" && password.Text == "pacijent")
            {
                PacijentForma pf = new PacijentForma();
                pf.Show();
                username.Text = "";
                password.Text = "";
            }
            else {//obicni login
                int imal = 0;
                foreach (Pacijent p in k.Pacijenti)
                {
                    if (p.Username == username.Text && p.Password == hash(password.Text))
                    {

                        PacijentForma pf = new PacijentForma();
                        pf.Show();
                        imal = 1;
                        //this.Hide();
                    }
                }
                foreach (Uposleni p in k.Uposlenici)
                {
                    if (p.Username == username.Text && p.Password == hash(password.Text))
                    {

                        UposleniForma uf = new UposleniForma();
                        DoktorForm df = new DoktorForm();
                        df.Show();
                        uf.Show();
                        imal = 1;
                        //this.Hide();
                    }
                }



                if (imal == 0) { errorProvider1.SetError(this.password, "Netacni podaci");
                    toolStripStatusLabel1.Text= "Pokusaj ponovo";
                                  }
                
            }



        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }
    }
}
    

