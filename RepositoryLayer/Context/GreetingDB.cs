using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelLayer.DTO;

namespace RepositoryLayer.Context
{
    public class GreetingDB:DbContext
    {
        public GreetingDB(DbContextOptions<GreetingDB> options) : base(options) { }

        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SAYA\\SQLEXPRESS;Database=GreetingApp1;IntegratedSecurity=True;");
            }
        }

    }
}
