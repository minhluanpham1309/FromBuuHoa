using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    public class BLL_Contract : IDisposable
    {
        public Cl_Database data;

        public BLL_Contract()
        {
            data = new Cl_Database();
        }
        public void Dispose()
        {
            if (data != null)
            {
                data.Dispose();
                data = null;
            }
        }
        public DataTable Check_id_code(ref string err, string id_code)
        {
            return data.getDataTable(ref err, "check_id_code", CommandType.StoredProcedure, new SqlParameter("@id_code", id_code));
        }

        public DataTable Add_Client(ref string err, int id, string name, string id_code, string address, string phone)
        {
            return data.getDataTable(ref err, "sp_create_NPerson", CommandType.StoredProcedure, new SqlParameter("@id", id), new SqlParameter("@name", name), new SqlParameter("@id_code", id_code), new SqlParameter("@address", address), new SqlParameter("@phone", phone));
        }
        public DataTable GetDataTableViewContract(ref string err)
        {
            return data.getDataTable(ref err, "sp_getdata_contract_view", CommandType.StoredProcedure, null);
        }
        public DataTable GetDataConboNameContract(ref string err)
        {
            return data.getDataTable(ref err, "load_data_name_contract", CommandType.StoredProcedure, null);
        }
        public DataTable GetDataConboTypeContract(ref string err)
        {
            return data.getDataTable(ref err, "load_data_nameCon_tyCon", CommandType.StoredProcedure, null);
        }
        public DataTable GetDataConboType(ref string err)
        {
            return data.getDataTable(ref err, "load_data_typeCon", CommandType.StoredProcedure, null);
        }
        public DataTable GetDataNotaryBook(ref string err)
        {
            return data.getDataTable(ref err, "load_data_nobo", CommandType.StoredProcedure, null);
        }
        public bool AddContractExcuNonQue(ref string err, string no_num, string name_per,string id_code,string address,
string phone, DateTime no_day,DateTime sign_day,int nu_book,string des,string ty_name,string type,int price,string sig_person, string note, int year_bo)
        {
            return data.ExNonQueryData(ref err, "add_contract", CommandType.StoredProcedure,new SqlParameter("@no_num", no_num), 
                new SqlParameter("@name_per", name_per),
                new SqlParameter("@id_code", id_code),
                new SqlParameter("@address", address),
                new SqlParameter("@phone", phone),
                new SqlParameter("@no_day", no_day),
                new SqlParameter("@sign_day", sign_day),
                new SqlParameter("@nu_book", nu_book),
                new SqlParameter("@des", des),
                new SqlParameter("@ty_name", ty_name),
                new SqlParameter("@type", type),
                new SqlParameter("@price", price),
                new SqlParameter("@sig_person", sig_person),
                new SqlParameter("@note", note),
                new SqlParameter("@year_bo", year_bo));

        }

        public bool UpdateContractExcuNonQue(ref string err, string no_num, string name_per, string id_code, string address,
string phone, DateTime no_day, DateTime sign_day, int nu_book, string des, string ty_name, string type, int price, string sig_person, string note, int year_bo)
        {
            return data.ExNonQueryData(ref err, "sp_update_contract", CommandType.StoredProcedure, new SqlParameter("@no_num", no_num),
                new SqlParameter("@name_per", name_per),
                new SqlParameter("@id_code", id_code),
                new SqlParameter("@address", address),
                new SqlParameter("@phone", phone),
                new SqlParameter("@no_day", no_day),
                new SqlParameter("@sign_day", sign_day),
                new SqlParameter("@nu_book", nu_book),
                new SqlParameter("@des", des),
                new SqlParameter("@ty_name", ty_name),
                new SqlParameter("@type", type),
                new SqlParameter("@price", price),
                new SqlParameter("@sig_person", sig_person),
                new SqlParameter("@note", note),
                new SqlParameter("@year_bo", year_bo));

        }
        public bool Update_Notary_Person(ref string err,string address, string phone, string name)
        {
            return data.ExNonQueryData(ref err, "sp_update_noperson", CommandType.StoredProcedure, new SqlParameter("@address", address), new SqlParameter("@phone", phone), new SqlParameter("@name)", name));
        }

        public DataTable Load_data_all_control_with_noNum(ref string err, string no_num)
        {
            return data.getDataTable(ref err, "load_data_all_controll_with_noNum", CommandType.StoredProcedure, new SqlParameter("@no_num", no_num));
        }
    }
}
