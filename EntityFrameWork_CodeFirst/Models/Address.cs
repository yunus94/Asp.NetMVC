
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CodeFirst.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength(300)]
        public string AddressDefinition { get; set; }

        public virtual Person Persons { get; set; }
    }

}