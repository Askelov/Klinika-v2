using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMK
{
    public partial class KorisnickaKontrola : UserControl
    {
        public KorisnickaKontrola()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog prozor = new OpenFileDialog();
            prozor.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg";
            prozor.InitialDirectory = @"C:\";
            prozor.Title = "Odaberi sliku";
            if (prozor.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(prozor.FileName);

            }
        }
    }
}
