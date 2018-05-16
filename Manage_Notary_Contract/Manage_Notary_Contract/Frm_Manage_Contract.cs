using Manage_Notary_Contract.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Notary_Contract
{
    public partial class Frm_detail_contract : Form
    {
        public Frm_detail_contract()
        {
            InitializeComponent();
        }
        BLL_Contract bll_contract;
        string err = string.Empty;
        DTO_Person_Notatry person;
        public DTO_Contract _dtocontract = null;
        DataTable table;
        DialogResult dialog;

       
        private void Frm_Manage_Contract_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            bll_contract = new BLL_Contract();
            dataTable = bll_contract.GetDataTableViewContract(ref err);
            if (_dtocontract != null)
            {
                load_defaul_view(dataTable);
                SetDTOToControl(_dtocontract);
            }
            else
            {
                load_defaul_view(dataTable);
            }
        }

        private void load_defaul_view(DataTable dataTable)
        {
            //load number book and year book
            DataTable data_notary_book = new DataTable();
            data_notary_book = bll_contract.GetDataNotaryBook(ref err);
            foreach (DataRow row in data_notary_book.Rows)
            {
                cbo_num_bo.Items.Add(row["Number_Of_Book"]);
                cbo_year.Items.Add(row["Year_Book"]);
            }
            cbo_num_bo.SelectedItem = data_notary_book.Rows[data_notary_book.Rows.Count - 1]["Number_Of_Book"];
            cbo_year.SelectedItem = data_notary_book.Rows[data_notary_book.Rows.Count - 1]["Year_Book"];

            //load notar number
            int count = dataTable.Rows.Count;
            int max = Convert.ToInt32((string)(dataTable.Rows[count - 1]["Notary_Number"]));

            foreach(DataRow row in dataTable.Rows)
            {
                int temp = Convert.ToInt32((string)row["Notary_Number"]);
                max = max > temp?max:temp;
            }

            if (count != 0)
            {
                int no_num_int = max + 1;
                txt_number_no.Text = no_num_int.ToString();
                txt_number_no.AutoCompleteCustomSource.Add((string)(dataTable.Rows[count - 1]["Notary_Number"]));
            }
            else
            {
                txt_number_no.Text = "";
            }

            //load cbo type contract
            DataTable table_cb_name = new DataTable();
            table_cb_name = bll_contract.GetDataConboNameContract(ref err);
            cbo_name_contract.Items.Add("Hãy chọn hợp đồng");
            cbo_name_contract.SelectedItem = "Hãy chọn hợp đồng";
            foreach (DataRow row in table_cb_name.Rows)
            {
                cbo_name_contract.Items.Add(row["Type_Name_Contract"]);
                cbo_name_contract.AutoCompleteCustomSource.Add((string)row["Type_Name_Contract"]);
            }

            DataTable tb_type = new DataTable();
            tb_type = bll_contract.GetDataConboType(ref err);
            cbo_type_contract.Items.Add("Hãy chọn loại hợp đồng");
            cbo_type_contract.SelectedItem = "Hãy chọn loại hợp đồng";
            foreach (DataRow row in tb_type.Rows)
            {
                cbo_type_contract.Items.Add(row["Name_Type"]);
                cbo_name_contract.AutoCompleteCustomSource.Add((string)row["Name_Type"]);
            }

            //load other control
            dpk_date_ask.Value = DateTime.Now;
            dpk_date_sign.Value = DateTime.Now;
            txt_price.Text = "0";
        }
       
        //private bool LoadDatabaseDTO(ref List<DTO_Person_Notatry> ls_dto, string id_code)
        //{
        //    bll_contract = new BLL_Contract();
        //    SqlDataReader dataReader = null;
        //    if (dataReader != null)
        //    {
        //        while (dataReader.Read())
        //        {
        //            foreach (DTO_Person_Notatry item in ls_dto)
        //            {
        //                item.Id = (int)dataReader["ID_NPerson"];
        //                item.Id_code = (string)dataReader["ID_Code"];
        //                item.Name = (string)dataReader["LastName"];
        //                item.Address = (string)dataReader["NPerson_Address"];
        //                item.Phone = "";
        //            }
                    
        //        }
        //        return true;
        //    }
        //    return false;
        //}
        private bool LoadDatabaseDTO(ref DTO_Person_Notatry dto, string id_code)
        {
            bll_contract = new BLL_Contract();
            SqlDataReader dataReader = null;
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    
                        dto.Id = (int)dataReader["ID_NPerson"];
                        dto.Id_code = (string)dataReader["ID_Code"];
                        dto.Name = (string)dataReader["LastName"];
                        dto.Address = (string)dataReader["NPerson_Address"];
                        dto.Phone = "";
           
                }
                return true;
            }
            return false;
        }
        // check id_code exits in table person notary 
        private bool check_id_code(ref string err, string id_code,ref DTO_Person_Notatry dto)
        {
            bll_contract = new BLL_Contract();
            DataTable dt = new DataTable();
            dt = bll_contract.Check_id_code(ref err, id_code);
            foreach (DataRow row in dt.Rows)
            {
                dto.Id = (int)row["ID_NPerson"];
                dto.Id_code = (string)row["ID_Code"];
                dto.Name = (string)row["LastName"];
                dto.Address = (string)row["NPerson_Address"];
                dto.Phone = "";
            }
            return dt.Rows.Count != 0 ? true : false;
        }
       
        // Auto add txt address when inputing in txt id_code finish 
        private void txt_id_code_Leave(object sender, EventArgs e)
        {
            
            person = new DTO_Person_Notatry();
            bool bo = check_id_code(ref err, txt_id_code.Text, ref person);
            if (bo)
            {
                txt_name_p.Text = person.Name;
                txt_address.Text = person.Address;
            }else
            {
                return;
            }
            
        }
        // auto select cbo type when choose cbo name_contract
        private void cbo_name_contract_SelectedIndexChanged(object sender, EventArgs e)
        {
            bll_contract = new BLL_Contract();
            DataTable tabletype = new DataTable();
            tabletype = bll_contract.GetDataConboTypeContract(ref err);

            foreach(DataRow row in tabletype.Rows)
            {
           
                if (cbo_name_contract.SelectedItem.Equals(row["Type_Name_Contract"]))
                {
                    cbo_type_contract.SelectedItem = row["Name_Type"];
                }
            }
            
        }

       
        private void Add_Contract( DTO_Contract con, BLL_Contract bll)
        {
            bool bo = bll.AddContractExcuNonQue(ref err, con.No_number, con.Dto_person_notary.Name, con.Dto_person_notary.Id_code, con.Dto_person_notary.Address, con.Dto_person_notary.Phone,con.Notary_date, con.Sign_date, con.Dto_notarybook.Number_book, con.Description, con.Dto_name_contract.Name_contract, con.Dto_type_contract.Name_type, (int)con.Price, con.Dto_notary.Name, con.Note, con.Dto_notarybook.Year_book);
            if (bo == true)
            {
                MessageBox.Show("Đã thêm hợp đồng");
            }
            else
                MessageBox.Show("Không thêm được hợp đồng");
        }
        private void Update_Contract(DTO_Contract con, BLL_Contract bll)
        {
            bool bo = bll.UpdateContractExcuNonQue(ref err, con.No_number, con.Dto_person_notary.Name, con.Dto_person_notary.Id_code, con.Dto_person_notary.Address, con.Dto_person_notary.Phone, con.Notary_date, con.Sign_date, con.Dto_notarybook.Number_book, con.Description, con.Dto_name_contract.Name_contract, con.Dto_type_contract.Name_type, (int)con.Price, con.Dto_notary.Name, con.Note, con.Dto_notarybook.Year_book);
            if (bo == true)
            {
                MessageBox.Show("Đã update hợp đồng");
            }
            else
                MessageBox.Show("Không update được hợp đồng");
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            bll_contract = new BLL_Contract();
            _dtocontract = new DTO_Contract();
            setAllcontrolToDTO(ref _dtocontract);
            table = bll_contract.GetDataTableViewContract(ref err);
            string num_no = string.Empty;
            bool stt = false;
            foreach (DataRow row in table.Rows)
            {
                num_no = (string)row["Notary_Number"];
                stt = _dtocontract.No_number.Equals(num_no) ? true : false;
            }
            if (stt)
                dialog = MessageBox.Show("Dữ liệu đã tồn tại");
                if(dialog == DialogResult.OK)
                    Update_Contract(_dtocontract, bll_contract);
            else
                Add_Contract(_dtocontract, bll_contract);
            this.Close();
            Frm_detail_contract frm_Detail = new Frm_detail_contract();
            frm_Detail.Show();
        }

        private void txt_address_Leave(object sender, EventArgs e)
        {
            person= new DTO_Person_Notatry();
            bool bo = check_id_code(ref err, txt_id_code.Text, ref person);
            if(!txt_address.Text.Equals(person.Address)&& bo)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn thay đổi địa chỉ?");
                if(dialog == DialogResult.OK)
                {
                    bll_contract.Update_Notary_Person(ref err, person.Address, person.Phone, person.Name);
                }
            }
        }

        private void cbo_name_contract_Leave(object sender, EventArgs e)
        {
            if(((string)cbo_name_contract.SelectedItem).Equals("Hãy chọn hợp đồng")||cbo_name_contract.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Hãy chọn loại hợp đồng");
                cbo_name_contract.Focus();
            }
                
        }

        private void txt_number_no_Leave(object sender, EventArgs e)
        {
            table = new DataTable();
            bll_contract = new BLL_Contract();
            DTO_Contract dto_contract = new DTO_Contract();
            table = bll_contract.Load_data_all_control_with_noNum(ref err, txt_number_no.Text);
            bool stt = false;
            stt = table.Rows.Count > 0 ? true : false;
           
            if(stt)
            {
                setDatabaseToDTO(table, bll_contract, ref dto_contract);
                SetDTOToControl(dto_contract);
            }
            
        }

        



        // Area set controls and DTO
        private void SetDTOToControl(DTO_Contract _dto)
        {
            if (_dto != null)
            {
                txt_number_no.Text = _dto.No_number;
                txt_name_p.Text = _dto.Dto_person_notary.Name;
                txt_id_code.Text = _dto.Dto_person_notary.Id_code;
                txt_address.Text = _dto.Dto_person_notary.Address;
                dpk_date_ask.Value = _dto.Notary_date;
                dpk_date_sign.Value = _dto.Sign_date;
                cbo_num_bo.SelectedItem = _dto.Dto_notarybook.Number_book;
                txt_description.Text = _dto.Description;
                cbo_name_contract.SelectedItem = _dto.Dto_name_contract.Name_contract;
                cbo_type_contract.SelectedItem = _dto.Dto_type_contract.Name_type;
                txt_price.Text = _dto.Price.ToString();
                txt_note.Text = _dto.Note;
                cbo_year.SelectedItem = _dto.Dto_notarybook.Year_book;
            }
        }
        private void setAllcontrolToDTO(ref DTO_Contract dto)
        {
            dto.No_number = (string)txt_number_no.Text;
            dto.Dto_person_notary.Name = txt_name_p.Text;
            dto.Dto_person_notary.Id_code = txt_id_code.Text;
            dto.Dto_person_notary.Address = txt_address.Text;
            dto.Dto_person_notary.Phone = "";
            dto.Notary_date = dpk_date_ask.Value;
            dto.Sign_date = dpk_date_sign.Value;
            dto.Dto_notarybook.Number_book = Convert.ToInt32(cbo_num_bo.SelectedItem.ToString());
            dto.Description = txt_description.Text;
            dto.Dto_name_contract.Name_contract = cbo_name_contract.SelectedItem.ToString();
            dto.Dto_type_contract.Name_type = cbo_type_contract.SelectedItem.ToString();
            dto.Price = Convert.ToDouble(txt_price.Text);
            dto.Note = txt_note.Text;
            dto.Dto_notary.Name = "Lê Thị Ngọc hiêp";
            dto.Dto_notarybook.Year_book = Convert.ToInt32(cbo_year.SelectedItem.ToString());
        }
       
        private void setDatabaseToDTO(DataTable table, BLL_Contract bll, ref DTO_Contract dto)
        {
          
                foreach (DataRow row in table.Rows)
                {
                    dto.No_number = (string)row["Notary_Number"];
                    dto.Description = (string)row["Description"];
                    dto.Notary_date = (DateTime)row["Notary_Date"];
                    dto.Sign_date = (DateTime)row["Sign_Date"];
                    dto.Price = (double)row["Notary_Price"];
                    dto.Note = (string)row["Note"];
                    dto.Dto_person_notary.Id_code = (string)row["ID_Code"];
                    dto.Dto_person_notary.Name = (string)row["LastName"];
                    dto.Dto_person_notary.Address = (string)row["NPerson_Address"];
                    dto.Dto_person_notary.Phone = "";
                    dto.Dto_name_contract.Name_contract = (string)row["Type_Name_Contract"];
                    dto.Dto_type_contract.Name_type = (string)row["Name_Type"];
                    dto.Dto_notarybook.Number_book = (int)row["Number_Of_Book"];
                    dto.Dto_notarybook.Year_book = (int)row["Year_Book"];
                    dto.Dto_notary.Name = (string)row["Name_Notary"];
                }
        }

        private void setControltoDTO(DTO_Person_Notatry dto)
        {
            txt_id_code.Text = dto.Id_code;
            txt_name_p.Text = dto.Name;
            lbl_add.Text = dto.Address;
        }

        private void btn_show_list_Click(object sender, EventArgs e)
        {
            List_Contract frm_list = new List_Contract();
            frm_list.Show();
        }
    }
}
