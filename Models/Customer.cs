using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_task_2.Models
{
    internal class Customer
    {
        [Key]
        public int id { get; set; }

        [MaxLength(100)]
        [Unicode(true)]
        public string name { get; set; } = string.Empty;

        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set; } = string.Empty;
        public string CreaditCardNumber { get; set; } = string.Empty;
        public string Sales { get; set; } = string.Empty;



    }
}
