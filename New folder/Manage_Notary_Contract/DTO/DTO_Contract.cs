using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Notary_Contract.DTO
{
    public class DTO_Contract
    {
        private string no_number, description, note;
        private DateTime notary_date, sign_date;
        private double price;
        private DTO_Type_Contract dto_type_contract;
        private DTO_Name_Contract dto_name_contract;
        private DTO_Person_Notatry dto_person_notary;
        private DTO_Notary dto_notary;
        private DTO_Notary_Book dto_notarybook;

        public double Price { get => price; set => price = value; }
        public DateTime Notary_date { get => notary_date; set => notary_date = value; }
        public DateTime Sign_date { get => sign_date; set => sign_date = value; }
        public string No_number { get => no_number; set => no_number = value; }
        public string Description { get => description; set => description = value; }
        public string Note { get => note; set => note = value; }
        internal DTO_Notary_Book Dto_notarybook { get => dto_notarybook; set => dto_notarybook = value; }
        internal DTO_Notary Dto_notary { get => dto_notary; set => dto_notary = value; }
        internal DTO_Person_Notatry Dto_person_notary { get => dto_person_notary; set => dto_person_notary = value; }
        internal DTO_Name_Contract Dto_name_contract { get => dto_name_contract; set => dto_name_contract = value; }
        internal DTO_Type_Contract Dto_type_contract { get => dto_type_contract; set => dto_type_contract = value; }

        public DTO_Contract()
        {
            dto_name_contract = new DTO_Name_Contract();
            dto_notary = new DTO_Notary();
            dto_person_notary = new DTO_Person_Notatry();
            dto_type_contract = new DTO_Type_Contract();
            dto_notarybook = new DTO_Notary_Book();
            No_number = no_number;
            Description = description;
            Note = note;
            Notary_date = notary_date;
            Sign_date = sign_date;
            Price = price;
            Dto_type_contract = dto_type_contract;
            Dto_name_contract = dto_name_contract;
            Dto_person_notary = dto_person_notary;
            Dto_notary = dto_notary;
            Dto_notarybook = dto_notarybook;
            Price = price;
            Notary_date = notary_date;
            Sign_date = sign_date;
            No_number = no_number;
            Description = description;
            Note = note;
            Dto_notarybook = dto_notarybook;
            Dto_notary = dto_notary;
            Dto_person_notary = dto_person_notary;
            Dto_name_contract = dto_name_contract;
            Dto_type_contract = dto_type_contract;
        }
    }
}
