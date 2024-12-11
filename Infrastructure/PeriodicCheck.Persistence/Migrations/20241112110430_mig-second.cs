using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicCheck.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migsecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeriodicActivityStatuses",
                columns: table => new
                {
                    Activity_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipment_id = table.Column<int>(type: "int", nullable: false),
                    ActivityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fault_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Report_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Report_person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solution_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Solution_person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İncharge_mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Care_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Techinician = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Care_report = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    next_care = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Situtation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notice_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notice_date = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_PeriodicActivityStatuses", x => x.Activity_id);
                    table.ForeignKey(
                        name: "FK_PeriodicActivityStatuses_Equipments_Equipment_id",
                        column: x => x.Equipment_id,
                        principalTable: "Equipments",
                        principalColumn: "Equipment_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicActivityStatuses_Equipment_id",
                table: "PeriodicActivityStatuses",
                column: "Equipment_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeriodicActivityStatuses");
        }
    }
}
