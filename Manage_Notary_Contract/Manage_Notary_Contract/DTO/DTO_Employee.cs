using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract
{
    class DTO_Employee
    {
        string name, salary;
        int id;
        DateTime bday, stday;
        bool stt;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Bday { get => bday; set => bday = value; }
        public DateTime Stday { get => stday; set => stday = value; }
        public string Salary { get => salary; set => salary = value; }
        public bool Stt { get => stt; set => stt = value; }
    }
}
