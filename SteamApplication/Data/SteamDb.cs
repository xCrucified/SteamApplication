using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamApplication.DatabaseContext
{
    public class SteamDb : DbContext
    {
        public SteamDb() : base()
        {

        }
        //--Create db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SteamDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(conn);
        }

        //--Inserts
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        //--Tables
        //public DbSet<???> ??? { get; set; }

    }
}
