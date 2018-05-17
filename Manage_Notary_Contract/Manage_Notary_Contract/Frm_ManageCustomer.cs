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
            bll = new BLL_Person();
            
            for (int i = dt_customer.Rows.Count -1; i > 0; --i)
            {
                
                if (dt_customer.Rows[i].Cells["col_check"].Selected)
                {
                    string del = dt_customer.Rows[i].Cells["col_check"].Value.ToString().Trim();
                    bool stt = false;
                    if (del.Equals("1"))
                    {
                        string s = dt_customer.Rows[i].Cells["col_id_code"].Value.ToString();
                        stt = bll.deleteCustomer(ref err, s);
                    }
                     
                    if (stt)
                        MessageBox.Show("da xoa");
                    else
                        MessageBox.Show("khong xoa duoc");
                }
            }
            load_GridView();
        }
        private void btn_addInfo_Click(object sender, EventArgs e)
        {
            
            DataTable data = new DataTable();
            bll = new BLL_Person();
            DTO_Person_Notatry add = new DTO_Person_Notatry();
           
            add.Name = txt_lastname.Text;
            add.Id_code = txt_CMND.Text;
            add.Address = txt_address.Text;
            add.Phone = txt_phoneNumber.Text;
            data = bll.addPersonData(ref err, add.Name, add.Id_code, add.Address, add.Phone);
            load_GridView();
        }
    }
}
