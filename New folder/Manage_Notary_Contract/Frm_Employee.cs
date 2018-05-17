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
    public partial class Frm_Employee : Form
    {
        public Frm_Employee()
        {
            InitializeComponent();
        }

        BLL_Employee bll;
        string err = string.Empty;
        DataTable List_Employee;
        DTO_Employee dem;
        
        private void LoadDTOToControl(DTO_Employee dte)
        {
            txt_name.Text = dte.Name;
            txt_bDay.Text = dte.Bday;
            txt_stDay.Text = dte.Stday;
            txt_salary.Text = dte.Salary;
          
        }

        private void loadGrvDataEmployee(ref string err)
        {
            bll = new BLL_Employee();
            List_Employee = new DataTable();
            List_Employee = bll.getEmployee(ref err);
            dataGridView1.DataSource = List_Employee;
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            //Cl_Database data = new Cl_Database();
            loadGrvDataEmployee(ref err);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dem = new DTO_Employee();
            dem.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_Id_Em"].Value.ToString());
            dem.Name = dataGridView1.CurrentRow.Cells["col_Name_Em"].Value.ToString();
            dem.Bday = dataGridView1.CurrentRow.Cells["col_birth_day"].Value.ToString().Substring(0,10);
            dem.Stday = dataGridView1.CurrentRow.Cells["col_start_day"].Value.ToString().Substring(0,10);
            dem.Salary = dataGridView1.CurrentRow.Cells["col_salary"].Value.ToString();
            LoadDTOToControl(dem);
        }

       
        private void btn_Del_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            bll = new BLL_Employee();
            for(int i = dataGridView1.RowCount - 1; i>0; i--)
            {
                if (dataGridView1.Rows[i].Cells["col_Check"].Selected)
                {
                    string s = dataGridView1.Rows[i].Cells["col_Check"].Value.ToString().Trim();
                    if (s.Equals("1"))
                    {
                        dt = bll.delEmployee(ref err, dataGridView1.Rows[i].Cells["col_Id_Em"].Value.ToString());
                    }
                }
            }
            loadGrvDataEmployee(ref err);
        }
        private void loadControlToDTO()
        {
            dem = new DTO_Employee();
            dem.Name = txt_name.Text;
            dem.Bday = txt_bDay.Text;
            dem.Stday = txt_stDay.Text;
            dem.Salary = txt_salary.Text;
        }

        //Nút thêm nhân viên
        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            bll = new BLL_Employee();
            loadControlToDTO();
            dt = bll.addEmployee(ref err, dem.Name, dem.Bday, dem.Stday, dem.Salary);
            loadGrvDataEmployee(ref err);
        }
        
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            loadControlToDTO();
            dem.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_Id_Em"].Value.ToString());
            if (bll.updateEmployee(ref err, dem.Id, dem.Name, dem.Bday, dem.Stday, dem.Salary))
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else{
                MessageBox.Show("Cập nhật thất bại");
            }
            loadGrvDataEmployee(ref err);
        }
    }
}
