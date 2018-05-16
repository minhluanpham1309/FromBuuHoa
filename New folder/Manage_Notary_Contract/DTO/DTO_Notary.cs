using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract.DTO
{
    class DTO_Notary
    {
        private string name, regency;

        public string Name { get => name; set => name = value; }
        public string Regency { get => regency; set => regency = value; }
    }
}
