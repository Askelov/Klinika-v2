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
    public partial class UposleniForma : Form
    {
        public UposleniForma()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
