using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicCheck.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFault_Care : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category_id",
                table: "Faults",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CareReports",
                columns: table => new
                {
                    CareReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedCare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousCareDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextCareDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_CareReports_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareReports_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Equipment_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaultDescriptions",
                columns: table => new
                {
                    FaultDescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FaultId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SelectedFault = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_FaultDescriptions", x => x.FaultDescriptionId);
                    table.ForeignKey(
                        name: "FK_FaultDescriptions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaultDescriptions_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Equipment_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaultDescriptions_Faults_FaultId",
                        column: x => x.FaultId,
                        principalTable: "Faults",
                        principalColumn: "Fault_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faults_Category_id",
                table: "Faults",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_CareReports_CategoryId",
                table: "CareReports",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CareReports_EquipmentId",
                table: "CareReports",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultDescriptions_CategoryId",
                table: "FaultDescriptions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultDescriptions_EquipmentId",
                table: "FaultDescriptions",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FaultDescriptions_FaultId",
                table: "FaultDescriptions",
                column: "FaultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Faults_Categories_Category_id",
                table: "Faults",
                column: "Category_id",
                principalTable: "Categories",
                principalColumn: "Category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faults_Categories_Category_id",
                table: "Faults");

            migrationBuilder.DropTable(
                name: "CareReports");

            migrationBuilder.DropTable(
                name: "FaultDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Faults_Category_id",
                table: "Faults");

            migrationBuilder.DropColumn(
                name: "Category_id",
                table: "Faults");
        }
    }
}
