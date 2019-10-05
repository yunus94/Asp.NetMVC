using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CodeFirst.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [StringLength (20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string SurName { get; set; }
        [Required]
        public int Age { get; set; }

        public virtual List<Address> Addresses { get; set; }
    }
}