using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline
{
    public partial class DetailsPage : Form
    {
        public DetailsPage(Image image, string[] subitems)
        {
            InitializeComponent();
            pictureBox1.Image = image;
            label6.Text = subitems[1];
            label7.Text = subitems[2];
            label8.Text = subitems[3];
            label9.Text = subitems[4];
            label10.Text = subitems[5];
            label11.Text = subitems[6];
            label13.Text = subitems[7];
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
