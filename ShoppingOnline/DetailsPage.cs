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
        public DetailsPage(Phone phone)
        {
            InitializeComponent();

            pictureBox1.Image = phone.Image;
            label9.Text = phone.Name;
            label10.Text = phone.Price;
            label11.Text = phone.details[0];
            label12.Text = phone.details[1];
            label13.Text = phone.details[2];
            label14.Text = phone.details[3];
            label15.Text = phone.details[4];
            label18.Text = phone.details[5];

        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
