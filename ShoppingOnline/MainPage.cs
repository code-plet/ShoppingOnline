using ShoppingOnline.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            InitializeItemShelves();
        }

        private void InitializeItemShelves()
        {
            Collection<Panel> panels = new Collection<Panel>();
            panels.Add(tableLayoutPanel27);
            panels.Add(tableLayoutPanel29);
            panels.Add(tableLayoutPanel31);
            panels.Add(tableLayoutPanel33);
            panels.Add(tableLayoutPanel35);
            panels.Add(tableLayoutPanel45);
            panels.Add(tableLayoutPanel41);
            panels.Add(tableLayoutPanel43);
            panels.Add(tableLayoutPanel37);
            panels.Add(tableLayoutPanel39);



            for (int i = 0; i < phones.Length; i++)
            {
                for (int j = 0; j < panels[i].Controls.Count; j++)
                {
                    if (panels[i].Controls[j] is PictureBox)
                    {
                        (panels[i].Controls[j] as PictureBox).Image = phones[i].Image;
                        continue;
                    }
                    if (panels[i].Controls[j] is Label)
                    {
                        (panels[i].Controls[j] as Label).Text = phones[i].Name;
                        continue;
                    }
                    if (panels[i].Controls[j] is TableLayoutPanel)
                    {
                        ((panels[i].Controls[j] as TableLayoutPanel).Controls[0] as Label).Text = phones[i].Price;
                        ((panels[i].Controls[j] as TableLayoutPanel).Controls[1] as Label).Text = "-" + phones[i].Discount + "%";

                        continue;
                    }
                }
            }
        }

        Phone[] phones = new Phone[]{
                new Phone(Resources.samsung_galaxy_s23_600x600, "Samsung Galaxy S23 5G", "20.990.000₫", 8, new string[] { "Dynamic AMOLED 2X", "Full HD+ (1080 x 2340 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz","1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz" }),
                new Phone(Resources.iphone_14_pro_max_vang_thumb_600x600, "iPhone 14 Pro Max", "27.490.000₫", 8, new string[] { "Dynamic AMOLED 2X", "Full HD+ (1080 x 2340 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz", "3.46 GHz" }),
                new Phone(Resources.iphone_14_pro_tim_thumb_600x600, "iPhone 14 Pro", "25.390.000₫", 9, new string[] { "Dynamic AMOLED 2X", "Full HD+ (1080 x 2340 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz", "3.46 GHz"}),
                new Phone(Resources.Samsung_Galaxy_S21_FE_vang_1_2_600x600, "Samsung Galaxy S21 FE 5G", "10.990.000₫", 15, new string[] { "Dynamic AMOLED 2X", "Full HD+ (1080 x 2340 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz", "1 nhân 2.9 GHz, 3 nhân 2.8 GHz & 4 nhân 2.2 GHz" }),
                new Phone(Resources.xiaomi_redmi_12c_grey_thumb_600x600, "Xiaomi Redmi 12C", "3.190.000₫", 11, new string[] { "Dynamic AMOLED 2X", "Full HD+ (1080 x 2340 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz", "2 nhân 2.0 GHz & 6 nhân 1.8 GHz" }),
                new Phone(Resources.samsung_galaxy_s23_ultra_1_600x600, "Samsung Galaxy S23 Ultra 5G", "26.990.000₫", 15, new string[] { "Dynamic AMOLED 2X", "2K+ (1440 x 3088 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz" }),
                new Phone(Resources.iphone_11_trang_600x600, "iPhone 11", "10.590.000₫",11, new string[] { "IPS LCD", "Liquid Retina (828 x 1792 Pixels)", "Kính cường lực Oleophobic (ion cường lực)", "iOS 15", "\r\nApple A13 Bionic 6 nhân", "\r\n2 nhân 2.65 GHz & 4 nhân 1.8 GHz" }),
                new Phone(Resources.vivo_y35_thumb_den_600x600, "Vivo Y35", "6.290.000₫",10, new string[] { "Dynamic AMOLED 2X", "2K+ (1440 x 3088 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz" }),
                new Phone(Resources.oppo_reno8t_vang1_thumb_600x600, "OPPO Reno8 T 5G", "10.990.000₫",1, new string[] { "Dynamic AMOLED 2X", "2K+ (1440 x 3088 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz" }),
                new Phone(Resources.realme_c35_vang_thumb_600x600, "realme C55", "4.690.000₫",6, new string[] { "Dynamic AMOLED 2X", "2K+ (1440 x 3088 Pixels)", "Kính cường lực Corning Gorilla Glass Victus 2", "Android 13", "Snapdragon 8 Gen 2 8 nhân", "\r\n1 nhân 3.36 GHz, 4 nhân 2.8 GHz & 3 nhân 2 GHz" }),
            };
private void panel3_Click(object sender, EventArgs e)
        {
            textBox1.Select();
            textBox1.Text = tableLayoutPanel26.GetType().ToString();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[0]);
            detailsPage.ShowDialog();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[1]);
            detailsPage.ShowDialog();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[2]);
            detailsPage.ShowDialog();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[3]);
            detailsPage.ShowDialog();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[4]);
            detailsPage.ShowDialog();
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[5]);
            detailsPage.ShowDialog();
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[6]);
            detailsPage.ShowDialog();
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[7]);
            detailsPage.ShowDialog();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[8]);
            detailsPage.ShowDialog();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            DetailsPage detailsPage = new DetailsPage(phones[9]);
            detailsPage.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
