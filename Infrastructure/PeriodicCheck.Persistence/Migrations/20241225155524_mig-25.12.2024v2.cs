using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicCheck.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig25122024v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Cares_CareId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CareId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CareId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Care_Name",
                table: "CareNames",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CareId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Care_Name",
                table: "CareNames",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CareId",
                table: "Categories",
                column: "CareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Cares_CareId",
                table: "Categories",
                column: "CareId",
                principalTable: "Cares",
                principalColumn: "CareId");
        }
    }
}
