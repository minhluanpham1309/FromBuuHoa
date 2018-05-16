using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    class DTO_Employee
    {
        string name, bday, stday, salary;
        int id;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Bday { get => bday; set => bday = value; }
        public string Stday { get => stday; set => stday = value; }
        public string Salary { get => salary; set => salary = value; }
    }
}
