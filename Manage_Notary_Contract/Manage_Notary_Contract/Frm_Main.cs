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

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Cl_Database database = new Cl_Database();
            string err = "";
            if(database.KiemTraKetNoi(ref err)==true)
            {
                MessageBox.Show("Ket koi thanh cong");
            }
            else
            {
                MessageBox.Show(err);
            }
            
        }

        private void menu_manage_em_Click(object sender, EventArgs e)
        {
            Frm_Employee frm_Employee = new Frm_Employee();
            frm_Employee.MdiParent = this;
            frm_Employee.Show();
        }

        private void menu_Manage_Contract_Click(object sender, EventArgs e)
        {

        }

        private void mn_add_contract_Click(object sender, EventArgs e)
        {
            Frm_detail_contract frm_Detail = new Frm_detail_contract();
            frm_Detail.MdiParent = this;
            frm_Detail.Show();
        }

        private void mn_list_contract_Click(object sender, EventArgs e)
        {
            List_Contract frm_list = new List_Contract();
            frm_list.MdiParent = this;
            frm_list.Show();
        }
    }
}
