using System;
using Microsoft.EntityFrameworkCore;

namespace BenimHesabim.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            string conString = "DESKTOP-2J5GSKH\\SQLEXPRESS;";
            optionsBuilder.UseSqlServer("server="+conString+" database=BenimHesabim; integrated security=true;");
        }

        public DbSet<Customer> Customers {get;set;}
        public DbSet<Log> Logs {get;set;}
    }
}

