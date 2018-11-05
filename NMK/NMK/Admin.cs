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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void korisnickaKontrola1_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string spol = "";
            if (radioButton1.Checked) spol = "musko";
            else spol = "zensko";
            string bstanje = "";
            if (radioButton4.Checked) bstanje = "ozenjen";
            else bstanje = "neozenjen";
            bool ziv = true;
            if (radioButton7.Checked)
                ziv = false;
            if(radioButton6.Checked)
            Form1.k.DodajPacijenta(new Pacijent(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, spol, bstanje, dateTimePicker1.Value, dateTimePicker2.Value));
            else
                Form1.k.DodajPacijenta(new HitniPacijent(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, spol, bstanje, dateTimePicker1.Value, dateTimePicker2.Value,ziv,textBox5.Text));

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "opis prve pomoci...";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string spol = "";
            if (radioButton16.Checked) spol = "musko";
            else spol = "zensko";
            string bstanje = "";
            if (radioButton14.Checked) bstanje = "ozenjen";
            else bstanje = "neozenjen";
            int plata;
            Int32.TryParse(textBox12.Text, out plata);
            Form1.k.DodajUposlenog(new Uposleni(textBox11.Text, textBox10.Text, textBox9.Text, textBox8.Text, spol, bstanje, dateTimePicker4.Value, textBox7.Text, plata, textBox13.Text));
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            dateTimePicker4.Value = DateTime.Now;
            textBox7.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
               

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.k.DodajKarton(new Karton(textBox20.Text, textBox19.Text, textBox18.Text, new List<Pregled>(), textBox16.Text, textBox21.Text, textBox17.Text));
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox16.Text = "";
            textBox21.Text = "";
            textBox17.Text = "";

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
