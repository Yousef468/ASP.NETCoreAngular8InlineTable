using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI1.Models
{
    public class Bank
    {
        [Key]
        public int BankID { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        [Required]
        public string BankName { get; set; }
    }
}
