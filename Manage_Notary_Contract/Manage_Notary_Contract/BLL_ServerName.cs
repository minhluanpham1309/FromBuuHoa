using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    public class BLL_ServerName
    {
        Cl_Database data;

        public BLL_ServerName()
        {
            data = new Cl_Database();
        }

        public string GetServerName()
        {
            return data.getServerName("GetServerName", CommandType.StoredProcedure);
        }
    }
}
