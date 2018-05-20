using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    public class BLL_Person : IDisposable
    {
        Cl_Database data;

        public BLL_Person()
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
        public DataTable loadDataPersonToGrid(ref string err)
        {
            return data.getDataTable(ref err, "Load_Data_Person", CommandType.StoredProcedure, null);
        }

        public bool deleteCustomer(ref string err, string id_code)
        {
            return data.ExNonQueryData(ref err, "sp_delete_customer", CommandType.StoredProcedure, new SqlParameter("@id_code", id_code));
        }

        public bool addPersonData(ref string err, string lastName, string id_code, string address, string phone)
        {
            return data.ExNonQueryData(ref err, "addCustomer",
                CommandType.StoredProcedure,
                new SqlParameter("@lastName", lastName),
                new SqlParameter("@id_code", id_code),
                new SqlParameter("@address", address),
                new SqlParameter("@phoneNumber", phone));
        }


        public bool editCustomerInfo(ref string err, int Id, string lastname, string id_code, string address, string phone)
        {
            return data.ExNonQueryData(ref err, "sp_edit_customer_info",
                CommandType.StoredProcedure,
                new SqlParameter("@Id", Id),
                new SqlParameter("@lastName", lastname),
                new SqlParameter("@id_code", id_code),
                new SqlParameter("@address", address),
                new SqlParameter("@phone", phone));
        }
    }
}
