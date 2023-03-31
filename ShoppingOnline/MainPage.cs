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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Image image = imageList1.Images[listView1.SelectedItems[0].Index];
            ListViewItem.ListViewSubItemCollection listViewSubItems = listView1.SelectedItems[0].SubItems;
            string[] subitems = new string[8];
            for(int i = 0; i < listViewSubItems.Count; i++)
            {
                subitems[i] = listViewSubItems[i].Text;
            }

            DetailsPage detailsPage = new DetailsPage(image, subitems);
            detailsPage.ShowDialog();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            AccountPage accountPage = new AccountPage();
            accountPage.ShowDialog();
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.ShowDialog();
        }

        private void listView1_SizeChanged(object sender, EventArgs e)
        {
            int columnwidth = listView1.Width / listView1.Columns.Count;
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].Width = columnwidth;
            }
        }
    }
}
