using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    public class CnnString
    {
        public static string machineName;
        public static string svName;
        public static string dbName = "Notary_Contract";
        public static string getServerName()
        {
            svName = Environment.MachineName;
            DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
            string s = null;
            if (table != null)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["InstanceName"].ToString() != null)
                    {
                        s = row["ServerName"].ToString() + "\\" + row["InstanceName"].ToString();
                    }
                    else
                    {
                        s = row["ServerName"].ToString();
                    }
                        
                }
                svName = s;
            }
            return svName;
        }

    }
}