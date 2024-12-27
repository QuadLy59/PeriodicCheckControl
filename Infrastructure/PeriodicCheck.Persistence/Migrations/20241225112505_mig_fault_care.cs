using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicCheck.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_fault_care : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Cares_CareId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Equipment_EquipmentId",
                table: "Warehouses");

            migrationBuilder.DropTable(
                name: "CareReports");

            migrationBuilder.DropColumn(
                name: "Report_Date",
                table: "FaultDetails");

            migrationBuilder.DropColumn(
                name: "Report_Person",
                table: "FaultDetails");

            migrationBuilder.DropColumn(
                name: "Solution_Date",
                table: "FaultDetails");

            migrationBuilder.DropColumn(
                name: "Solution_Person",
                table: "FaultDetails");

            migrationBuilder.DropColumn(
                name: "Care_Date",
                table: "Cares");

            migrationBuilder.DropColumn(
                name: "Care_Name",
                table: "CareDetails");

            migrationBuilder.DropColumn(
                name: "Care_Photo",
                table: "CareDetails");

            migrationBuilder.RenameColumn(
                name: "Fault_Name",
                table: "Faults",
                newName: "Solution_Person");

            migrationBuilder.RenameColumn(
                name: "Care_DetailId",
                table: "CareDetails",
                newName: "CareDetailId");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "Warehouses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "FaultNameId",
                table: "Faults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Report_Date",
                table: "Faults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Report_Person",
                table: "Faults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Solution_Date",
                table: "Faults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FaultNameId",
                table: "FaultDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CareId",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CareNameId",
                table: "Cares",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "Care_Photo",
                table: "Cares",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "CareNameId",
                table: "CareDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Care_Date",
                table: "CareDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "CareMaterials",
                columns: table => new
                {
                    CareMaterialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_CareMaterials", x => x.CareMaterialId);
                    table.ForeignKey(
                        name: "FK_CareMaterials_Cares_CareId",
                        column: x => x.CareId,
                        principalTable: "Cares",
                        principalColumn: "CareId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CareMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CareNames",
                columns: table => new
                {
                    CareNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Care_Name = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_CareNames", x => x.CareNameId);
                });

            migrationBuilder.CreateTable(
                name: "FaultNames",
                columns: table => new
                {
                    FaultNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fault_Name = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_FaultNames", x => x.FaultNameId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faults_FaultNameId",
                table: "Faults",
                column: "FaultNameId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultDetails_FaultNameId",
                table: "FaultDetails",
                column: "FaultNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Cares_CareNameId",
                table: "Cares",
                column: "CareNameId");

            migrationBuilder.CreateIndex(
                name: "IX_CareDetails_CareNameId",
                table: "CareDetails",
                column: "CareNameId");

            migrationBuilder.CreateIndex(
                name: "IX_CareMaterials_CareId",
                table: "CareMaterials",
                column: "CareId");

            migrationBuilder.CreateIndex(
                name: "IX_CareMaterials_MaterialId",
                table: "CareMaterials",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_CareDetails_CareNames_CareNameId",
                table: "CareDetails",
                column: "CareNameId",
                principalTable: "CareNames",
                principalColumn: "CareNameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cares_CareNames_CareNameId",
                table: "Cares",
                column: "CareNameId",
                principalTable: "CareNames",
                principalColumn: "CareNameId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Cares_CareId",
                table: "Categories",
                column: "CareId",
                principalTable: "Cares",
                principalColumn: "CareId");

            migrationBuilder.AddForeignKey(
                name: "FK_FaultDetails_FaultNames_FaultNameId",
                table: "FaultDetails",
                column: "FaultNameId",
                principalTable: "FaultNames",
                principalColumn: "FaultNameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faults_FaultNames_FaultNameId",
                table: "Faults",
                column: "FaultNameId",
                principalTable: "FaultNames",
                principalColumn: "FaultNameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Equipment_EquipmentId",
                table: "Warehouses",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareDetails_CareNames_CareNameId",
                table: "CareDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Cares_CareNames_CareNameId",
                table: "Cares");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Cares_CareId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_FaultDetails_FaultNames_FaultNameId",
                table: "FaultDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Faults_FaultNames_FaultNameId",
                table: "Faults");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouses_Equipment_EquipmentId",
                table: "Warehouses");

            migrationBuilder.DropTable(
                name: "CareMaterials");

            migrationBuilder.DropTable(
                name: "CareNames");

            migrationBuilder.DropTable(
                name: "FaultNames");

            migrationBuilder.DropIndex(
                name: "IX_Faults_FaultNameId",
                table: "Faults");

            migrationBuilder.DropIndex(
                name: "IX_FaultDetails_FaultNameId",
                table: "FaultDetails");

            migrationBuilder.DropIndex(
                name: "IX_Cares_CareNameId",
                table: "Cares");

            migrationBuilder.DropIndex(
                name: "IX_CareDetails_CareNameId",
                table: "CareDetails");

            migrationBuilder.DropColumn(
                name: "FaultNameId",
                table: "Faults");

            migrationBuilder.DropColumn(
                name: "Report_Date",
                table: "Faults");

            migrationBuilder.DropColumn(
                name: "Report_Person",
                table: "Faults");

            migrationBuilder.DropColumn(
                name: "Solution_Date",
                table: "Faults");

            migrationBuilder.DropColumn(
                name: "FaultNameId",
                table: "FaultDetails");

            migrationBuilder.DropColumn(
                name: "CareNameId",
                table: "Cares");

            migrationBuilder.DropColumn(
                name: "Care_Photo",
                table: "Cares");

            migrationBuilder.DropColumn(
                name: "CareNameId",
                table: "CareDetails");

            migrationBuilder.DropColumn(
                name: "Care_Date",
                table: "CareDetails");

            migrationBuilder.RenameColumn(
                name: "Solution_Person",
                table: "Faults",
                newName: "Fault_Name");

            migrationBuilder.RenameColumn(
                name: "CareDetailId",
                table: "CareDetails",
                newName: "Care_DetailId");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentId",
                table: "Warehouses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Report_Date",
                table: "FaultDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Report_Person",
                table: "FaultDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Solution_Date",
                table: "FaultDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Solution_Person",
                table: "FaultDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CareId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Care_Date",
                table: "Cares",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Care_Name",
                table: "CareDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Care_Photo",
                table: "CareDetails",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateTable(
                name: "CareReports",
                columns: table => new
                {
                    CareReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CareId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    CareReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_user = table.Column<int>(type: "int", nullable: true),
                    Ins_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ins_user = table.Column<int>(type: "int", nullable: true),
                    Is_active = table.Column<bool>(type: "bit", nullable: false),
                    Is_deleted = table.Column<bool>(type: "bit", nullable: false),
                    Updated_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_user = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareReports", x => x.CareReportId);
                    table.ForeignKey(
                        name: "FK_CareReports_Cares_CareId",
                        column: x => x.CareId,
                        principalTable: "Cares",
                        principalColumn: "CareId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CareReports_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CareReports_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CareReports_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Cares_CareId",
                table: "Categories",
                column: "CareId",
                principalTable: "Cares",
                principalColumn: "CareId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouses_Equipment_EquipmentId",
                table: "Warehouses",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
