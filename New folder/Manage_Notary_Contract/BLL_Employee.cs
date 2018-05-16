using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    class BLL_Employee : IDisposable
    {
        Cl_Database database;
        public void Dispose()
        {
           if(database != null)
            {
                database.Dispose();
                database = null;
            }
        }

        public BLL_Employee()
        {
            database = new Cl_Database();
        }

        public DataTable getEmployee(ref string err)
        {
            return database.getDataTable(ref err, "sp_get_info_employ", CommandType.StoredProcedure, null);
        }
        public DataTable delEmployee(ref string err, string id)
        {
            return database.getDataTable(ref err, "sp_del_em", CommandType.StoredProcedure, new SqlParameter("@id", id));
        }
        public DataTable addEmployee(ref string err, string name, string bDay, string stDay, string salary)
        {
            return database.getDataTable(ref err, "sp_add_em", CommandType.StoredProcedure,new SqlParameter("@name", name), 
                new SqlParameter("@bday", bDay), 
                new SqlParameter("@stday", stDay), 
                new SqlParameter("@salary", salary));
        }
        public bool updateEmployee(ref string err, int id, string name, string bDay, string stDay, string salary)
        {
            return database.ExNonQueryData(ref err, "sp_update_em", CommandType.StoredProcedure, new SqlParameter("@id", id), new SqlParameter("@name", name),
                new SqlParameter("@bday", bDay),
                new SqlParameter("@stday", stDay),
                new SqlParameter("@salary", salary));
        }
    }
}
