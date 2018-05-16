using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract.DTO
{
    class DTO_Notary_Book
    {
        private int number_book;
        private int year_book;

        public int Number_book { get => number_book; set => number_book = value; }
        public int Year_book { get => year_book; set => year_book = value; }
    }
}
