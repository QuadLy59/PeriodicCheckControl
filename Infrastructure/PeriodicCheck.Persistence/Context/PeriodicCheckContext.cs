using Microsoft.EntityFrameworkCore;
using PeriodicCheck.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicCheck.Persistence.Context
{
    public class PeriodicCheckContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial Catalog=PeriodicCheckDb;integrated Security=true;TrustServerCertificate=true");
        }
        public DbSet <Care> Cares { get; set; }
        public DbSet <Equipment> Equipments { get; set; }
        public DbSet <Fault> Faults { get; set; }
        public DbSet <Notice> Notices { get; set; }
        public DbSet <Stock> Stocks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<PeriodicActivityStatus> PeriodicActivityStatuses { get; set; }
        public DbSet<FaultDescription> FaultDescriptions { get; set; }
        public DbSet<CareReport> CareReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.Warehouse)
                .WithMany(w => w.Equipments)
                .HasForeignKey(e => e.Warehouse_id);

            


            modelBuilder.Entity<Equipment>()
            .HasOne(e => e.Category)
            .WithMany(c => c.Equipments)
            .HasForeignKey(e => e.Category_id);

            modelBuilder.Entity<Fault>()
           .HasOne(m => m.Equipment)
           .WithMany(e => e.Faults)
           .HasForeignKey(m => m.Equipment_id);

            modelBuilder.Entity<Care>()
            .HasOne(m => m.Equipment)
            .WithMany(e => e.Cares)
            .HasForeignKey(m => m.Equipment_id);

            modelBuilder.Entity<Stock>()
          .HasOne(s => s.Equipment)
          .WithMany(e => e.Stocks)
          .HasForeignKey(s => s.Equipment_id);

            modelBuilder.Entity<Notice>()
          .HasOne(n => n.Equipment)
           .WithMany(e => e.Notices)
           .HasForeignKey(n => n.Equipment_id);


            modelBuilder.Entity<PeriodicActivityStatus>()
               .HasOne(p => p.Equipment)
               .WithMany(e => e.periodicActivityStatuses)
               .HasForeignKey(p => p.Equipment_id);


            modelBuilder.Entity<Fault>()
             .HasMany(f => f.FaultDescriptions)  
             .WithOne(fd => fd.Fault)
             .HasForeignKey(fd => fd.FaultId)
             .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<FaultDescription>()
     .HasOne(fd => fd.Fault)
     .WithMany(f => f.FaultDescriptions)
     .HasForeignKey(fd => fd.FaultId)
     .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FaultDescription>()
                .HasOne(fd => fd.Category)
                .WithMany(c => c.FaultDescriptions) 
                .HasForeignKey(fd => fd.CategoryId);

         




        }

    }

}
