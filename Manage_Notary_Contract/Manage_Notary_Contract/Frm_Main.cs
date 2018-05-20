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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        Cl_Database db = new Cl_Database();
        public string err = string.Empty;

        public void Frm_Main_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(db.KiemTraKetNoi(ref err) ? "Connected" : "Fail\n" + err);

        }

        private void menu_manage_em_Click(object sender, EventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            Frm_Employee frm_Employee = new Frm_Employee();
            frm_Employee.MdiParent = this;
            frm_Employee.Show();
        }

       

        private void mn_add_contract_Click(object sender, EventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            Frm_detail_contract frm_Detail = new Frm_detail_contract();
            frm_Detail.MdiParent = this;
            frm_Detail.Show();
        }

        private void mn_list_contract_Click(object sender, EventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            List_Contract frm_list = new List_Contract();
            frm_list.MdiParent = this;
            frm_list.Show();
        }


        private void tSmenuBttDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult questionaire = MessageBox.Show("Bạn có muốn đăng xuất ra khỏi chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (questionaire == DialogResult.OK)
            {
                Frm_Login logIn = new Frm_Login();
                this.Hide();
                logIn.Show();
            }
        }

        private void tsMenuBttThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            Frm_ManageCustomer customer = new Frm_ManageCustomer();
            customer.MdiParent = this;
            customer.Show();

        }
    }
}
