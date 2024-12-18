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
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Care", b =>
                {
                    b.Property<int>("Care_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Care_id"));

                    b.Property<DateTime>("Care_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Care_report")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("Equipment_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Techinician")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.Property<DateTime>("next_care")
                        .HasColumnType("datetime2");

                    b.HasKey("Care_id");

                    b.HasIndex("Equipment_id");

                    b.ToTable("Cares");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.CareReport", b =>
                {
                    b.Property<int>("CareReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareReportId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<DateTime>("NextCareDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PreviousCareDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SelectedCare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("CareReportId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentId");

                    b.ToTable("CareReports");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_id"));

                    b.Property<string>("Category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("Category_id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Equipment", b =>
                {
                    b.Property<int>("Equipment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Equipment_id"));

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<string>("Communication")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Equipment_name")
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

                    b.Property<string>("Responsible")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.Property<int>("Warehouse_id")
                        .HasColumnType("int");

                    b.HasKey("Equipment_id");

                    b.HasIndex("Category_id");

                    b.HasIndex("Warehouse_id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Fault", b =>
                {
                    b.Property<int>("Fault_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fault_id"));

                    b.Property<string>("Case")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Category_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("Equipment_id")
                        .HasColumnType("int");

                    b.Property<string>("Fault_description")
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

                    b.Property<DateTime>("Report_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Report_person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Solution_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Solution_person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("Fault_id");

                    b.HasIndex("Category_id");

                    b.HasIndex("Equipment_id");

                    b.ToTable("Faults");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.FaultDescription", b =>
                {
                    b.Property<int>("FaultDescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaultDescriptionId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("SelectedFault")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("FaultDescriptionId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("FaultId");

                    b.ToTable("FaultDescriptions");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Notice", b =>
                {
                    b.Property<int>("Notice_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Notice_id"));

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("Equipment_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Notice_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notice_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.Property<string>("İncharge_mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Notice_id");

                    b.HasIndex("Equipment_id");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.PeriodicActivityStatus", b =>
                {
                    b.Property<int>("Activity_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Activity_id"));

                    b.Property<DateTime>("ActivityDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ActivityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Care_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Care_report")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Equipment_id")
                        .HasColumnType("int");

                    b.Property<string>("Fault_description")
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

                    b.Property<DateTime>("Notice_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notice_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Report_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Report_person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situtation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Solution_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Solution_person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Techinician")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.Property<DateTime>("next_care")
                        .HasColumnType("datetime2");

                    b.Property<string>("İncharge_mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Activity_id");

                    b.HasIndex("Equipment_id");

                    b.ToTable("PeriodicActivityStatuses");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Stock", b =>
                {
                    b.Property<int>("Stock_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Stock_id"));

                    b.Property<DateTime?>("Deleted_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Deleted_user")
                        .HasColumnType("int");

                    b.Property<int>("Equipment_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Ins_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Ins_user")
                        .HasColumnType("int");

                    b.Property<bool>("Is_active")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Situtation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.HasKey("Stock_id");

                    b.HasIndex("Equipment_id");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Warehouse", b =>
                {
                    b.Property<int>("Warehouse_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Warehouse_id"));

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

                    b.Property<DateTime?>("Updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Updated_user")
                        .HasColumnType("int");

                    b.Property<string>("Warehouse_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Warehouse_id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Care", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Cares")
                        .HasForeignKey("Equipment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.CareReport", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Equipment", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Category", "Category")
                        .WithMany("Equipments")
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("Equipments")
                        .HasForeignKey("Warehouse_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Fault", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Category", null)
                        .WithMany("Faults")
                        .HasForeignKey("Category_id");

                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Faults")
                        .HasForeignKey("Equipment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.FaultDescription", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Category", "Category")
                        .WithMany("FaultDescriptions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("FaultDescriptions")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PeriodicCheck.Domain.Entities.Fault", "Fault")
                        .WithMany("FaultDescriptions")
                        .HasForeignKey("FaultId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Equipment");

                    b.Navigation("Fault");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Notice", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Notices")
                        .HasForeignKey("Equipment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.PeriodicActivityStatus", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("periodicActivityStatuses")
                        .HasForeignKey("Equipment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Stock", b =>
                {
                    b.HasOne("PeriodicCheck.Domain.Entities.Equipment", "Equipment")
                        .WithMany("Stocks")
                        .HasForeignKey("Equipment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Category", b =>
                {
                    b.Navigation("Equipments");

                    b.Navigation("FaultDescriptions");

                    b.Navigation("Faults");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Equipment", b =>
                {
                    b.Navigation("Cares");

                    b.Navigation("FaultDescriptions");

                    b.Navigation("Faults");

                    b.Navigation("Notices");

                    b.Navigation("Stocks");

                    b.Navigation("periodicActivityStatuses");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Fault", b =>
                {
                    b.Navigation("FaultDescriptions");
                });

            modelBuilder.Entity("PeriodicCheck.Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Equipments");
                });
#pragma warning restore 612, 618
        }
    }
}
