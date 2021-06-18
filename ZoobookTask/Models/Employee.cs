using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ZoobookTask.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string MiddleName { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }
    }
}
