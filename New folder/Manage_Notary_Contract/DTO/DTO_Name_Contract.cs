using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract.DTO
{
    class DTO_Name_Contract
    {
        private int id_tcontract, number_side;
        private string name_contract;
        private DTO_Type_Contract type_contract;

        public int Id_tcontract { get => id_tcontract; set => id_tcontract = value; }
        public int Number_side { get => number_side; set => number_side = value; }
        public string Name_contract { get => name_contract; set => name_contract = value; }
        internal DTO_Type_Contract Type_contract { get => type_contract; set => type_contract = value; }
    }
}
