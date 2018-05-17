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
    public partial class Frm_ForgetPass : Form
    {
        public Frm_ForgetPass()
        {
            InitializeComponent();
        }

        private void TextFocusAppear(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "Email address or phone number")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void TextFocusDisappear(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "")
            {
                tb.Text = "Email address or phone number";
                tb.ForeColor = Color.LightGray;
            }
        }

        private void Frm_ForgetPass_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lbInstruction;
            txtSearch.GotFocus += new EventHandler(this.TextFocusAppear);
            txtSearch.LostFocus += new EventHandler(this.TextFocusDisappear);
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtSearch.Text, "admin") == 0)
            {
                DialogResult notice;
                notice = MessageBox.Show("Your password is admin.");

                if (DialogResult.OK == notice)
                {
                    this.Hide();
                    Frm_Login logIn = new Frm_Login();
                    logIn.Show();
                }
            }
            else
            {
                MessageBox.Show("Your search did not return any results. Please try again with other information.");
            }
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttSearch.PerformClick();
            }
        }
    }
}
