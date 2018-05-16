using Manage_Notary_Contract.DTO;
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
    public partial class List_Contract : Form
    {
        public List_Contract()
        {
            InitializeComponent();
        }
        BLL_Contract bll_contact;
        DTO_Contract dto_contract;
        DataTable table_Contract;
        string err = string.Empty;
        private void btn_change_Click(object sender, EventArgs e)
        {

        }
        
        private void List_Contract_Load(object sender, EventArgs e)
        {
           
            LoadGridViewContract();
        }
        private void LoadGridViewContract()
        {
            bll_contact = new BLL_Contract();
            table_Contract = new DataTable();
            table_Contract = bll_contact.GetDataTableViewContract(ref err);
            dataGridView1.DataSource = table_Contract;
        }

        private void thaydoi_Click(object sender, EventArgs e)
        {
            Frm_detail_contract frm_Detail = new Frm_detail_contract();
            frm_Detail._dtocontract = dto_contract;
            frm_Detail.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dto_contract = new DTO_Contract();
            dto_contract.No_number = dataGridView1.CurrentRow.Cells[""].Value.ToString();
        }
    }
}
