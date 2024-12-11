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
                name: "Categories",
                columns: table => new
                {
                    Category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Categories", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Warehouse_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Warehouse_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Warehouses", x => x.Warehouse_id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Equipment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serial_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Warehouse_id = table.Column<int>(type: "int", nullable: false),
                    Responsible = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Communication = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category_id = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Equipments", x => x.Equipment_id);
                    table.ForeignKey(
                        name: "FK_Equipments_Categories_Category_id",
                        column: x => x.Category_id,
                        principalTable: "Categories",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_Warehouses_Warehouse_id",
                        column: x => x.Warehouse_id,
                        principalTable: "Warehouses",
                        principalColumn: "Warehouse_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cares",
                columns: table => new
                {
                    Care_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_id = table.Column<int>(type: "int", nullable: false),
                    Care_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Techinician = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Care_report = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    next_care = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Cares", x => x.Care_id);
                    table.ForeignKey(
                        name: "FK_Cares_Equipments_Equipment_id",
                        column: x => x.Equipment_id,
                        principalTable: "Equipments",
                        principalColumn: "Equipment_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faults",
                columns: table => new
                {
                    Fault_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_id = table.Column<int>(type: "int", nullable: false),
                    Fault_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Report_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Report_person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solution_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Solution_person = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Faults", x => x.Fault_id);
                    table.ForeignKey(
                        name: "FK_Faults_Equipments_Equipment_id",
                        column: x => x.Equipment_id,
                        principalTable: "Equipments",
                        principalColumn: "Equipment_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Notice_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_id = table.Column<int>(type: "int", nullable: false),
                    Notice_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notice_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    İncharge_mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Notices", x => x.Notice_id);
                    table.ForeignKey(
                        name: "FK_Notices_Equipments_Equipment_id",
                        column: x => x.Equipment_id,
                        principalTable: "Equipments",
                        principalColumn: "Equipment_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Stock_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Situtation = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Stocks", x => x.Stock_id);
                    table.ForeignKey(
                        name: "FK_Stocks_Equipments_Equipment_id",
                        column: x => x.Equipment_id,
                        principalTable: "Equipments",
                        principalColumn: "Equipment_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cares_Equipment_id",
                table: "Cares",
                column: "Equipment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Category_id",
                table: "Equipments",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Warehouse_id",
                table: "Equipments",
                column: "Warehouse_id");

            migrationBuilder.CreateIndex(
                name: "IX_Faults_Equipment_id",
                table: "Faults",
                column: "Equipment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Notices_Equipment_id",
                table: "Notices",
                column: "Equipment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_Equipment_id",
                table: "Stocks",
                column: "Equipment_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cares");

            migrationBuilder.DropTable(
                name: "Faults");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Warehouses");
        }
    }
}
