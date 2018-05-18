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
            dt_BDay.Value = dte.Bday;
            dt_StDay.Value = dte.Stday;
            txt_salary.Text = dte.Salary;
        }

        private void loadGrvDataEmployee(ref string err)
        {
            bll = new BLL_Employee();
            List_Employee = new DataTable();
            if (cbo_stt.SelectedItem.Equals("Đang làm"))
                List_Employee = bll.Load_Employee_with_Stt(ref err, false);
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            cbo_stt.SelectedItem = "Đang làm";
            loadGrvDataEmployee(ref err);
        }

       
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dem = new DTO_Employee();
            dem.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_Id_Em"].Value.ToString());
            dem.Name = dataGridView1.CurrentRow.Cells["col_Name_Em"].Value.ToString();
            dem.Bday = (DateTime)dataGridView1.CurrentRow.Cells["col_birth_day"].Value;
            dem.Stday = (DateTime)dataGridView1.CurrentRow.Cells["col_start_day"].Value;
            dem.Salary = dataGridView1.CurrentRow.Cells["col_salary"].Value.ToString();
            dem.Stt = (bool)dataGridView1.CurrentRow.Cells["col_stt"].Value;
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
                    bool stt;
                    stt = !(bool)dataGridView1.Rows[i].Cells["col_stt"].Value;
                    bll.updateSTT(ref err, (int)dataGridView1.Rows[i].Cells["col_Id_Em"].Value, DateTime.Now, stt);
                    
                }
            }
            cbo_stt_SelectedIndexChanged(sender, e);
        }
        private void loadControlToDTO()
        {
            dem = new DTO_Employee();
            dem.Name = txt_name.Text;
            dem.Bday = dt_BDay.Value;
            dem.Stday = dt_StDay.Value;
            dem.Salary = txt_salary.Text;
        }

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

        private void cbo_stt_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_Employee = new DataTable();
            bll = new BLL_Employee();
            if (cbo_stt.SelectedIndex == 0)
            {
                List_Employee = bll.getEmployee(ref err);
            }
            if (cbo_stt.SelectedIndex == 1)
            {
                List_Employee = bll.Load_Employee_with_Stt(ref err, false);
            }
            if (cbo_stt.SelectedIndex == 2)
            {
                List_Employee = bll.Load_Employee_with_Stt(ref err, true);
            }
            dataGridView1.DataSource = List_Employee;
        }
    }
}
