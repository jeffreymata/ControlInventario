﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiInventario.Features.Models;

namespace WebApiInventario.Features.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentDetail> Details { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=JAMF\LOCALSERVER;DataBase=NewDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>().HasKey(q => q.Id);
            modelBuilder.Entity<Equipment>().Property(e => e.Id).IsRequired().UseSqlServerIdentityColumn()
                 .HasMaxLength(50).IsRequired();
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DetailsMap());
            modelBuilder.ApplyConfiguration(new EquipmentMap());
            base.OnModelCreating(modelBuilder);
        }
        */
    }
}
