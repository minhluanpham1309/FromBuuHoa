namespace Manage_Notary_Contract
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Notary_Person
    {
        [Key]
        public int ID_NPerson { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_Code { get; set; }

        [Column(TypeName = "ntext")]
        public string NPerson_Address { get; set; }

        [StringLength(15)]
        public string Phone_Number { get; set; }
    }
}
