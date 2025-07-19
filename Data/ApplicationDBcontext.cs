using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_task_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef_task_2.Data
{


  
    internal class ApplicationDBcontext: DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Integrated Security=True;Initial Catalog = Task_517; Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

    }
}
