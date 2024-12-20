using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicCheck.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migfirst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorities",
                columns: table => new
                {
                    AuthorityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorities", x => x.AuthorityId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "RoleAuthorities",
                columns: table => new
                {
                    RoleAuthorityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AuthorityId = table.Column<int>(type: "int", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAuthorities", x => x.RoleAuthorityId);
                    table.ForeignKey(
                        name: "FK_RoleAuthorities_Authorities_AuthorityId",
                        column: x => x.AuthorityId,
                        principalTable: "Authorities",
                        principalColumn: "AuthorityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleAuthorities_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    RoleAuthorityId = table.Column<int>(type: "int", nullable: false),
                    AuthorityId = table.Column<int>(type: "int", nullable: false),
                    Name_And_Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_Number = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<byte>(type: "tinyint", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Authorities_AuthorityId",
                        column: x => x.AuthorityId,
                        principalTable: "Authorities",
                        principalColumn: "AuthorityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_RoleAuthorities_RoleAuthorityId",
                        column: x => x.RoleAuthorityId,
                        principalTable: "RoleAuthorities",
                        principalColumn: "RoleAuthorityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CareDetails",
                columns: table => new
                {
                    Care_DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Care_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selected_Care = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Care_Photo = table.Column<byte>(type: "tinyint", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareDetails", x => x.Care_DetailId);
                });

            migrationBuilder.CreateTable(
                name: "CareReports",
                columns: table => new
                {
                    CareReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CareId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareReports", x => x.CareReportId);
                });

            migrationBuilder.CreateTable(
                name: "Cares",
                columns: table => new
                {
                    CareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    Care_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Technician = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Next_Care_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Previ_Care_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Control_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Care_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cares", x => x.CareId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    CareId = table.Column<int>(type: "int", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Cares_CareId",
                        column: x => x.CareId,
                        principalTable: "Cares",
                        principalColumn: "CareId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serial_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsible_Communication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shift_Turn = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CareId = table.Column<int>(type: "int", nullable: false),
                    StockId = table.Column<int>(type: "int", nullable: false),
                    FaultId = table.Column<int>(type: "int", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_Equipment_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faults",
                columns: table => new
                {
                    FaultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fault_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Selected_Fault = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    Fault_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faults", x => x.FaultId);
                    table.ForeignKey(
                        name: "FK_Faults_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                    table.ForeignKey(
                        name: "FK_Materials_Cares_CareId",
                        column: x => x.CareId,
                        principalTable: "Cares",
                        principalColumn: "CareId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materials_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stocks_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Warehouse_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.WarehouseId);
                    table.ForeignKey(
                        name: "FK_Warehouses_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaultDetails",
                columns: table => new
                {
                    FaultDetailId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FaultId = table.Column<int>(type: "int", nullable: false),
                    Report_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Report_Person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solution_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Solution_Person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaultDetails", x => x.FaultDetailId);
                    table.ForeignKey(
                        name: "FK_FaultDetails_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FaultDetails_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FaultDetails_Faults_FaultDetailId",
                        column: x => x.FaultDetailId,
                        principalTable: "Faults",
                        principalColumn: "FaultId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CareDetails_CareId",
                table: "CareDetails",
                column: "CareId");

            migrationBuilder.CreateIndex(
                name: "IX_CareDetails_MaterialId",
                table: "CareDetails",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_CareReports_CareId",
                table: "CareReports",
                column: "CareId");

            migrationBuilder.CreateIndex(
                name: "IX_CareReports_CategoryId",
                table: "CareReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CareReports_EquipmentId",
                table: "CareReports",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CareReports_MaterialId",
                table: "CareReports",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Cares_EquipmentId",
                table: "Cares",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CareId",
                table: "Categories",
                column: "CareId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CategoryId",
                table: "Equipment",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_WarehouseId",
                table: "Equipment",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultDetails_CategoryId",
                table: "FaultDetails",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultDetails_EquipmentId",
                table: "FaultDetails",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Faults_EquipmentId",
                table: "Faults",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CareId",
                table: "Materials",
                column: "CareId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_EquipmentId",
                table: "Materials",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAuthorities_AuthorityId",
                table: "RoleAuthorities",
                column: "AuthorityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAuthorities_RoleId",
                table: "RoleAuthorities",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_CategoryId",
                table: "Stocks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_EquipmentId",
                table: "Stocks",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AuthorityId",
                table: "Users",
                column: "AuthorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleAuthorityId",
                table: "Users",
                column: "RoleAuthorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_EquipmentId",
                table: "Warehouses",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_CareDetails_Cares_CareId",
                table: "CareDetails",
                column: "CareId",
                principalTable: "Cares",
                principalColumn: "CareId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CareDetails_Materials_MaterialId",
                table: "CareDetails",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CareReports_Cares_CareId",
                table: "CareReports",
                column: "CareId",
                principalTable: "Cares",
                principalColumn: "CareId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CareReports_Categories_CategoryId",
                table: "CareReports",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CareReports_Equipment_EquipmentId",
                table: "CareReports",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CareReports_Materials_MaterialId",
                table: "CareReports",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_Equipment_EquipmentId",
                table: "Cares",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Warehouses_WarehouseId",
                table: "Equipment",
                column: "WarehouseId",
                principalTable: "Warehouses",
                principalColumn: "WarehouseId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Cares_CareId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Categories_CategoryId",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Equipment_EquipmentId",
                table: "Warehouses");

            migrationBuilder.DropTable(
                name: "CareDetails");

            migrationBuilder.DropTable(
                name: "CareReports");

            migrationBuilder.DropTable(
                name: "FaultDetails");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Faults");

            migrationBuilder.DropTable(
                name: "RoleAuthorities");

            migrationBuilder.DropTable(
                name: "Authorities");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Cares");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
