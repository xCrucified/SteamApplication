﻿using Microsoft.EntityFrameworkCore;
using SteamApplication.Data.Utilities.SeederData;
using SteamApplication.Entities;
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
            //configs
            //modelBuilder.ApplyConfiguration(new ???());
            //seeders
            modelBuilder.Seed();
        }

        //--Tables
        public DbSet<Category> Category { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Market> Market { get; set; }
        public DbSet<Platform> Platform { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<User> User { get; set; }
    }
}
