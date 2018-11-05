using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NMK
{
    public partial class Graf : Form
    {
        public Graf()
        {
            InitializeComponent();
        }

        private void Graf_Load(object sender, EventArgs e)
        {
        }
        private void GrafForm_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush plavaBojaBrush = new SolidBrush(Color.Blue);
            SolidBrush orangeBojaBrush = new SolidBrush(Color.Orange);
            SolidBrush ljubicastaBojaBrush = new SolidBrush(Color.Purple);
            SolidBrush crvenaBojaBrush = new SolidBrush(Color.Red);

            e.Graphics.DrawString("Uposleni", new Font("Times New Roman", 10, FontStyle.Bold), plavaBojaBrush, 10, 10);
            e.Graphics.DrawString("Pacijenti", new Font("Times New Roman", 10, FontStyle.Bold), orangeBojaBrush, 10, 30);
            e.Graphics.DrawString("Kartoni", new Font("Times New Roman", 10, FontStyle.Bold), ljubicastaBojaBrush, 10, 50);
            e.Graphics.DrawString("Ostalo", new Font("Times New Roman", 10, FontStyle.Bold), crvenaBojaBrush, 10, 70);

            Rectangle pravougaonik = new Rectangle(100, 100, 200, 200);


            int up = Form1.k.DajBrojUposlenih();
            int pa = Form1.k.DajBrojPacijenata();
            int ka = Form1.k.DajBrojKartona();
            int os = 0;





            e.Graphics.FillPie(plavaBojaBrush, pravougaonik, 0, 90);
            e.Graphics.FillPie(orangeBojaBrush, pravougaonik, 90, 90);
            e.Graphics.FillPie(ljubicastaBojaBrush, pravougaonik, 180, 90);
            e.Graphics.FillPie(crvenaBojaBrush, pravougaonik, 270, 90);
        }
    }
}
