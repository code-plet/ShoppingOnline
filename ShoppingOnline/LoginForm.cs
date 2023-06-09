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
    public partial class loginForm : Form
    {
        public loginForm()
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
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Nhập mật khẩu")
            {
                passwordTextBox.Clear();
                passwordTextBox.PasswordChar = '*';
                passwordTextBox.ForeColor = Color.Black;
            }

        }

        private void revealPasswordButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text != "Nhập mật khẩu")
            {
                if (passwordTextBox.PasswordChar == '*')
                    passwordTextBox.PasswordChar = '\0';
                else
                    passwordTextBox.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(usernameTextbox.Text == "giakhanh" && passwordTextBox.Text == "giakhanh")
            {
                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("lỗi đăng nhập");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void exitLabel_MouseEnter(object sender, EventArgs e)
        {
            exitLabel.Font = new Font(exitLabel.Font, FontStyle.Underline);
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.Font = new Font(exitLabel.Font,FontStyle.Bold);

        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
