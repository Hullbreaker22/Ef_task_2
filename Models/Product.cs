using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_task_2.Models
{
    internal class Product 
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(250)]
        public string Description { get; set; } = "No description ";
     
        public decimal Quantity { get; set; }
        public int Price { get; set; }
        public int Sales { get; set; }

    }
}
