using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Torpago.Models
{
    public class CustomerDetail
    {
        [Key]
        public int PMid { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string CustomerName { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public String State { get; set; }

        [Required]
        public int ZipCode { get; set; }
    }
}
