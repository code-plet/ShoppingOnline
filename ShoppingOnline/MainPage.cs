﻿using System;
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
            ListViewItem.ListViewSubItemCollection listViewSubItems = listView1.SelectedItems[0].SubItems;
            string[] subitems = new string[3];
            for(int i = 0; i < listViewSubItems.Count; i++)
            {
                subitems[i] = listViewSubItems[i].Text;
            }
        }
    }
}
