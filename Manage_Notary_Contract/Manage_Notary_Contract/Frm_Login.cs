using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Notary_Contract
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private bool CompareTwoString(string s1, string s2)
        {
            return string.Compare(s1, s2) == 0;
        }

        public void bttLogIn_Click(object sender, EventArgs e)
        {
            string userName = "admin", passWord = "admin";

            if (CompareTwoString(userName, txtUsername.Text) && CompareTwoString(passWord, txtPassword.Text))
            {
                MessageBox.Show("Log In successfuly!!!");
                this.Hide();
                Frm_Main main = new Frm_Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!!!");
                txtUsername.Text = txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLbForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ForgetPass pass = new Frm_ForgetPass();
            this.Hide();
            pass.ShowDialog();
            this.Show();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbLogin;
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Email address or phone number")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Email address or phone number";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '#';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Enter password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttLogIn.PerformClick();
            }
        }
    }
}
