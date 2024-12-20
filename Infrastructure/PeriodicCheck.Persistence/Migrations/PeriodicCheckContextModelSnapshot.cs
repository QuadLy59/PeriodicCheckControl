﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeriodicCheck.Persistence.Context;

#nullable disable

namespace PeriodicCheck.Persistence.Migrations
{
    [DbContext(typeof(PeriodicCheckContext))]
    partial class PeriodicCheckContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Authority", b =>
                {
                    b.Property<int>("AuthorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorityId"));

                    b.Property<string>("AuthorityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("AuthorityId");

                    b.ToTable("Authorities");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Care", b =>
                {
                    b.Property<int>("CareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareId"));

                    b.Property<DateTime>("Care_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Care_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Control_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Next_Care_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Previ_Care_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Technician")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("CareId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Cares");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.CareDetail", b =>
                {
                    b.Property<int>("Care_DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Care_DetailId"));

                    b.Property<int>("CareId")
                        .HasColumnType("int");

                    b.Property<string>("Care_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Care_Photo")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<string>("Selected_Care")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("Care_DetailId");

                    b.HasIndex("CareId");

                    b.HasIndex("MaterialId");

                    b.ToTable("CareDetails");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.CareReport", b =>
                {
                    b.Property<int>("CareReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareReportId"));

                    b.Property<int>("CareId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CareReportDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("CareReportId");

                    b.HasIndex("CareId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("MaterialId");

                    b.ToTable("CareReports");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("CareId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("CareId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"));

                    b.Property<int>("CareId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Equipment_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FaultId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Responsible")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsible_Communication")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Shift_Turn")
                        .HasColumnType("bit");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("EquipmentId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Fault", b =>
                {
                    b.Property<int>("FaultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaultId"));

                    b.Property<string>("Case")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<string>("Fault_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fault_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Selected_Fault")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("FaultId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Faults");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.FaultDetail", b =>
                {
                    b.Property<int>("FaultDetailId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("FaultId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Report_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Report_Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Solution_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Solution_Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("FaultDetailId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("FaultDetails");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"));

                    b.Property<int>("CareId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Material_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("MaterialId");

                    b.HasIndex("CareId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Role_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.RoleAuthority", b =>
                {
                    b.Property<int>("RoleAuthorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleAuthorityId"));

                    b.Property<int>("AuthorityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("RoleAuthorityId");

                    b.HasIndex("AuthorityId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleAuthorities");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("StockId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("AuthorityId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name_And_Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Password")
                        .HasColumnType("tinyint");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("int");

                    b.Property<int>("RoleAuthorityId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("AuthorityId");

                    b.HasIndex("RoleAuthorityId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarehouseId"));

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.Property<string>("Warehouse_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Care", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Cares")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.CareDetail", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Care", "Care")
                        .WithMany("CareDetails")
                        .HasForeignKey("CareId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Material", "Material")
                        .WithMany("CareDetails")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Care");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.CareReport", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Care", "Care")
                        .WithMany("CareReports")
                        .HasForeignKey("CareId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Category", "Category")
                        .WithMany("CareReports")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("CareReports")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Material", "Material")
                        .WithMany("CareReports")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Care");

                    b.Navigation("Category");

                    b.Navigation("Equipment");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Category", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Care", "Care")
                        .WithMany("Categories")
                        .HasForeignKey("CareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Care");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Equipment", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Category", "Category")
                        .WithMany("Equipment")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("Equipment")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Fault", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Faults")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.FaultDetail", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Category", "Category")
                        .WithMany("FaultDetails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("FaultDetails")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Fault", "Fault")
                        .WithMany("FaultDetails")
                        .HasForeignKey("FaultDetailId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Equipment");

                    b.Navigation("Fault");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Material", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Care", "Care")
                        .WithMany("Materials")
                        .HasForeignKey("CareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Materials")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Care");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.RoleAuthority", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Authority", "Authority")
                        .WithMany("RoleAuthorities")
                        .HasForeignKey("AuthorityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Role", "Role")
                        .WithMany("RoleAuthorities")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Authority");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Stock", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Category", "Category")
                        .WithMany("Stocks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Stocks")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.User", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Authority", "Authority")
                        .WithMany("Users")
                        .HasForeignKey("AuthorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.RoleAuthority", "RoleAuthority")
                        .WithMany("Users")
                        .HasForeignKey("RoleAuthorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Authority");

                    b.Navigation("Role");

                    b.Navigation("RoleAuthority");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Warehouse", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", null)
                        .WithMany("Warehouses")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Authority", b =>
                {
                    b.Navigation("RoleAuthorities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Care", b =>
                {
                    b.Navigation("CareDetails");

                    b.Navigation("CareReports");

                    b.Navigation("Categories");

                    b.Navigation("Materials");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Category", b =>
                {
                    b.Navigation("CareReports");

                    b.Navigation("Equipment");

                    b.Navigation("FaultDetails");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Equipment", b =>
                {
                    b.Navigation("CareReports");

                    b.Navigation("Cares");

                    b.Navigation("FaultDetails");

                    b.Navigation("Faults");

                    b.Navigation("Materials");

                    b.Navigation("Stocks");

                    b.Navigation("Warehouses");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Fault", b =>
                {
                    b.Navigation("FaultDetails");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Material", b =>
                {
                    b.Navigation("CareDetails");

                    b.Navigation("CareReports");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Role", b =>
                {
                    b.Navigation("RoleAuthorities");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.RoleAuthority", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Equipment");
                });
#pragma warning restore 612, 618
        }
    }
}
