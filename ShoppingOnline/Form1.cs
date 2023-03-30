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
    public partial class ShoppingOnline : Form
    {
        public ShoppingOnline()
        {
            InitializeComponent();
        }

        private void usernameTextbox_Leave(object sender, EventArgs e)
        {
            if(usernameTextbox.Text.Length == 0)
            {
                usernameTextbox.Text = "Nhập tên tài khoản";
                usernameTextbox.ForeColor = Color.Gray;
            }
        }

        private void usernameTextbox_Enter(object sender, EventArgs e)
        {
            if(usernameTextbox.Text == "Nhập tên tài khoản")
                usernameTextbox.Clear();

            usernameTextbox.ForeColor = Color.Black;

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length == 0)
            {
                passwordTextBox.Text = "Nhập mật khẩu";
                passwordTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Nhập mật khẩu")
                passwordTextBox.Clear();

            passwordTextBox.ForeColor = Color.Black;
        }
    }
}
