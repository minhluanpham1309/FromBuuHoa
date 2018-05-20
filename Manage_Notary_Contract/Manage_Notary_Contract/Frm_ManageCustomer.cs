using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Manage_Notary_Contract
{
    public partial class Frm_ManageCustomer : Form
    {
        public Frm_ManageCustomer()
        {
            InitializeComponent();
        }
        DataTable data;
        BLL_Person bll;
        DTO_Person_Notatry person;
        string err = string.Empty;
        private void load_GridView()
        {
        
            data = new DataTable();
            bll = new BLL_Person();
            person = new DTO_Person_Notatry();
            data = bll.loadDataPersonToGrid(ref err);
            dt_customer.DataSource = data;
        }
        private void Frm_ManageCustomer_Load(object sender, EventArgs e)
        {
            load_GridView();
        }

        private void dt_customer_Click(object sender, EventArgs e)
        {
            person = new DTO_Person_Notatry();
            person.Name = dt_customer.CurrentRow.Cells["col_name"].Value.ToString();
            person.Id_code = dt_customer.CurrentRow.Cells["col_id_code"].Value.ToString();
            person.Address = dt_customer.CurrentRow.Cells["col_address"].Value.ToString();
            person.Phone = dt_customer.CurrentRow.Cells["col_phone"].Value.ToString();
            load_DTO_To_Control(person);
        }
        private void load_DTO_To_Control(DTO_Person_Notatry dto)
        {
            if (dto != null)
            {
                txt_lastname.Text = dto.Name;
                txt_CMND.Text = dto.Id_code;
                txt_address.Text = dto.Address;
                txt_phoneNumber.Text = dto.Phone;
            }
        }

        private void btn_deleteInfo_Click(object sender, EventArgs e)
        {
            BLL_Person bll = new BLL_Person();

            for (int i = dt_customer.Rows.Count - 1; i >= 0; i--)
            {

                if (dt_customer.Rows[i].Cells["col_check"].Selected)
                {
                    string del = dt_customer.Rows[i].Cells["col_check"].Value.ToString().Trim();
                    if (del.Equals("1"))
                    {
                        string s = dt_customer.Rows[i].Cells["col_id_code"].Value.ToString().Trim();
                        bll.deleteCustomer(ref err, s);
                    }
                }
            }
            load_GridView();
        }

        private void btn_addInfo_Click(object sender, EventArgs e)
        {
            person = new DTO_Person_Notatry();
            person.Name = txt_lastname.Text.Trim();
            person.Id_code = txt_CMND.Text.Trim();
            person.Address = txt_address.Text.Trim();
            person.Phone = txt_phoneNumber.Text.Trim();
            string data = bll.addPersonData(ref err, person.Name, person.Id_code, person.Address, person.Phone).ToString();
            load_GridView();
        }
        private void loadControlToDTO()
        {
            person = new DTO_Person_Notatry();
            person.Name = txt_lastname.Text;
            person.Id_code = txt_CMND.Text;
            person.Address = txt_address.Text;
            person.Phone = txt_phoneNumber.Text;
        }

        private void btn_editInfo_Click(object sender, EventArgs e)
        {
            loadControlToDTO();
            person.Id = int.Parse(dt_customer.CurrentRow.Cells["col_ID"].Value.ToString());
            if (bll.editCustomerInfo(ref err, person.Id, person.Name, person.Id_code, person.Address, person.Phone))
            {
                MessageBox.Show("Đã sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
            load_GridView();
        }


    }
}
