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
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           int t = (int)numericUpDown1.Value;
           int c = (int)numericUpDown1.Value;
            Form1.k.DodajPregled(new Pregled(textBox1.Text, textBox2.Text, textBox3.Text, textBox7.Text, textBox8.Text, textBox1.Text, textBox2.Text, textBox3.Text, c, textBox9.Text, textBox10.Text, dateTimePicker1.Value, t));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
