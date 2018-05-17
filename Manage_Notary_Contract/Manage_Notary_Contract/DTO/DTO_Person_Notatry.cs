using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    class DTO_Person_Notatry
    {
        int id;
        bool is_Delete;
        string name, address, id_code, phone;

        public int Id { get => id; set => id = value; }
       
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Id_code { get => id_code; set => id_code = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Is_Delete { get => is_Delete; set => is_Delete = value; }
    }
}
