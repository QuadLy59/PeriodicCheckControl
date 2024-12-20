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
            optionsBuilder.UseSqlServer("Server=.;initial Catalog=PeriodicCheckDB;integrated Security=true;TrustServerCertificate=true");
        }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Care> Cares { get; set; }
        public DbSet<CareDetail> CareDetails { get; set; }
        public DbSet<CareReport> CareReports { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Fault> Faults { get; set; }
        public DbSet<FaultDetail> FaultDetails { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleAuthority> RoleAuthorities { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // RoleAuthorization
            modelBuilder.Entity<RoleAuthority>()
                .HasOne(ra => ra.Role)
                .WithMany(r => r.RoleAuthorities)
                .HasForeignKey(ra => ra.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RoleAuthority>()
                .HasOne(ra => ra.Authority)
                .WithMany(r => r.RoleAuthorities)
                .HasForeignKey(ra => ra.AuthorityId)
                .OnDelete(DeleteBehavior.Restrict);

            // Care
            modelBuilder.Entity<Care>()
                .HasOne(c => c.Equipment)
                .WithMany(e => e.Cares)
                .HasForeignKey(c => c.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // CareDetail
            modelBuilder.Entity<CareDetail>()
                .HasOne(cd => cd.Care)
                .WithMany(c => c.CareDetails)
                .HasForeignKey(cd => cd.CareId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CareDetail>()
                .HasOne(cd => cd.Material)
                .WithMany(m => m.CareDetails)
                .HasForeignKey(cd => cd.MaterialId)
                .OnDelete(DeleteBehavior.Restrict);

            // CareReport
            modelBuilder.Entity<CareReport>()
                .HasOne(cr => cr.Care)
                .WithMany(c => c.CareReports)
                .HasForeignKey(cr => cr.CareId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CareReport>()
                .HasOne(cr => cr.Equipment)
                .WithMany(e => e.CareReports)
                .HasForeignKey(cr => cr.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CareReport>()
                .HasOne(cr => cr.Category)
                .WithMany(c => c.CareReports)
                .HasForeignKey(cr => cr.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Fault
            modelBuilder.Entity<Fault>()
                .HasOne(f => f.Equipment)
                .WithMany(e => e.Faults)
                .HasForeignKey(f => f.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // FaultDetail
            modelBuilder.Entity<FaultDetail>()
                .HasOne(fd => fd.Fault)
                .WithMany(f => f.FaultDetails)
                .HasForeignKey(fd => fd.FaultDetailId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FaultDetail>()
                .HasOne(fd => fd.Equipment)
                .WithMany(e => e.FaultDetails)
                .HasForeignKey(fd => fd.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<FaultDetail>()
                .HasOne(fd => fd.Category)
                .WithMany(c => c.FaultDetails)
                .HasForeignKey(fd => fd.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Equipment
            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.Warehouse)
                .WithMany(w => w.Equipment)
                .HasForeignKey(e => e.WarehouseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Equipment>()
                .HasOne(e => e.Category)
                .WithMany(c => c.Equipment)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Stock
            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Equipment)
                .WithMany(e => e.Stocks)
                .HasForeignKey(s => s.EquipmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Category)
                .WithMany(c => c.Stocks)
                .HasForeignKey(s => s.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // User
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }

}
