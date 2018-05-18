using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage_Notary_Contract.DTO;

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
            DataTable data = LoadDataNoBook();
            foreach (DataRow row in data.Rows)
            {
                tol_cbo_year.Items.Add(row["Year_Book"]);
            }
            AutoArrMonth();
            tol_cbo_year.SelectedItem = DateTime.Now.Year;
            tol_cbo_month.SelectedItem = DateTime.Now.Month;
            int month = (int)tol_cbo_month.SelectedItem;
            int year = (int)tol_cbo_year.SelectedItem;
            AutoArrDay(month, year);
            tol_cbo_year.SelectedItem = DateTime.Now.Day;
        }
        private void LoadGridViewContract()
        {
            bll_contact = new BLL_Contract();
            table_Contract = new DataTable();
            table_Contract = bll_contact.GetDataTableViewContract(ref err);
            dataGridView1.DataSource = table_Contract;
        }
        public DataTable LoadDataNoBook()
        {
            DataTable data = new DataTable();
            return data = bll_contact.GetDataNotaryBook(ref err);
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dto_contract = new DTO_Contract();
            LoadGridViewToDTO(dto_contract);
        }

        public void LoadGridViewToDTO(DTO_Contract dto)
        {
            dto.No_number = dataGridView1.CurrentRow.Cells["col_no_num"].Value.ToString();
            dto.Dto_person_notary.Name = dataGridView1.CurrentRow.Cells["col_name"].Value.ToString();
            dto.Dto_person_notary.Id_code = dataGridView1.CurrentRow.Cells["col_id_code"].Value.ToString();
            dto.Dto_person_notary.Address = dataGridView1.CurrentRow.Cells["col_address"].Value.ToString();
            dto.Dto_person_notary.Phone = "";
            dto.Notary_date = (DateTime)dataGridView1.CurrentRow.Cells["col_no_date"].Value;
            dto.Sign_date = (DateTime)dataGridView1.CurrentRow.Cells["col_sig_date"].Value;
            dto.Dto_notarybook.Number_book = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_nu_book"].Value.ToString());
            dto.Description = dataGridView1.CurrentRow.Cells["col_des"].Value.ToString();
            dto.Dto_name_contract.Name_contract = dataGridView1.CurrentRow.Cells["col_type_name"].Value.ToString();
            dto.Dto_type_contract.Name_type = dataGridView1.CurrentRow.Cells["col_type"].Value.ToString();
            dto.Price = Convert.ToDouble(dataGridView1.CurrentRow.Cells["col_price"].Value.ToString());
            dto.Note = dataGridView1.CurrentRow.Cells["col_not"].Value.ToString();
            dto.Dto_notary.Name = dataGridView1.CurrentRow.Cells["col_name_no"].Value.ToString();
            dto.Dto_notarybook.Year_book = Convert.ToInt32(((DateTime)dataGridView1.CurrentRow.Cells["col_no_date"].Value).Year);

        }
        private void tol_cbo_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            table_Contract = new DataTable();


            bll_contact = new BLL_Contract();
            tol_cbo_year.Enabled = true;
            tol_cbo_month.Enabled = true;
            tol_cbo_day.Enabled = true;
            if (tol_cbo_show.SelectedItem.Equals("Xem Tất Cả"))
            {
                tol_cbo_year.Enabled = false;
                tol_cbo_month.Enabled = false;
                tol_cbo_day.Enabled = false;
                table_Contract = bll_contact.GetDataTableViewContract(ref err);
                dataGridView1.DataSource = table_Contract;
            }


            if (tol_cbo_show.SelectedItem.Equals("Xem Theo Năm"))
            {
                tol_cbo_month.Enabled = false;
                tol_cbo_day.Enabled = false;
                int year = (int)tol_cbo_year.SelectedItem;
                table_Contract = bll_contact.Load_data_with_Year(ref err, year);
                dataGridView1.DataSource = table_Contract;
            }
            if (tol_cbo_show.SelectedItem.Equals("Xem Theo Tháng"))
            {
                tol_cbo_day.Enabled = false;
                int month = (int)tol_cbo_month.SelectedItem;
                table_Contract = bll_contact.Load_data_with_Month(ref err, month);
                dataGridView1.DataSource = table_Contract;
            }
            if (tol_cbo_show.SelectedItem.Equals("Xem Theo Ngày"))
            {
                tol_cbo_day.Enabled = (tol_cbo_day.Enabled == false) ? true : true;
                int day = DateTime.Now.Day;
                if (tol_cbo_day.SelectedItem != null)
                    day = (int)tol_cbo_day.SelectedItem;
                table_Contract = bll_contact.Load_data_with_Day(ref err, day);
                dataGridView1.DataSource = table_Contract;
            }

        }
        private bool check_year(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                return true;
            return false;
        }
        private int[] AutoArrMonth()
        {
            int[] arrmonth = new int[12];
            for (int i = 0; i < 12; i++)
            {
                arrmonth[i] = i + 1;
                tol_cbo_month.Items.Add(arrmonth[i]);
            }
            return arrmonth;
        }

        private int[] AutoArrDay(int month, int year)
        {
            int[] arrday = null;

            int tempMonth = 0;
            switch (month)
            {
                case 2: tempMonth = check_year(year) ? 29 : 28; break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: tempMonth = 31; break;
                default:
                    tempMonth = 30;
                    break;
            }
            arrday = new int[tempMonth];
            for (int i = 0; i < tempMonth; i++)
            {
                arrday[i] = i + 1;
                tol_cbo_day.Items.Add(arrday[i]);
            }
            return arrday;
        }

        private void tol_btn_change_Click(object sender, EventArgs e)
        {
            Frm_detail_contract frm_Detail = new Frm_detail_contract();
            if (dto_contract != null)
            {

                frm_Detail._dtocontract = dto_contract;
                frm_Detail.Show();
            }
            else
            {
                frm_Detail.Show();
            }

        }

        private void tol_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            table_Contract = new DataTable();
            dto_contract = new DTO_Contract();
            bll_contact = new BLL_Contract();

            if (tol_find.SelectedItem.Equals("Theo Tên"))
            {

                table_Contract = bll_contact.Load_data_with_name(ref err, tol_txt_find.Text);
                if (stt)
                    if (tol_txt_find.Text == "")
                    {
                        MessageBox.Show("Bạn chưa điền tên");
                        tol_txt_find.Focus();
                    }
                dataGridView1.DataSource = table_Contract;
            }
            if (tol_find.SelectedItem.Equals("Theo CMND"))
            {
                table_Contract = bll_contact.Load_data_with_id_code(ref err, tol_txt_find.Text);
                if (stt)
                    if (tol_txt_find.Text == "")
                    {
                        MessageBox.Show("Bạn chưa điền CMND");
                        tol_txt_find.Focus();
                    }
                dataGridView1.DataSource = table_Contract;
            }
            if (tol_find.SelectedItem.Equals("Theo SCC"))
            {
                table_Contract = bll_contact.Load_data_with_no_num(ref err, tol_txt_find.Text);
                if (stt)
                    if (tol_txt_find.Text == "")
                    {
                        MessageBox.Show("Bạn chưa điền SCC");
                        tol_txt_find.Focus();
                    }
                dataGridView1.DataSource = table_Contract;
            }
        }
        bool stt = false;
        private void tol_txt_find_Leave(object sender, EventArgs e)
        {
            stt = true;
        }
    }
}
