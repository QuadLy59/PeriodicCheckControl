using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeriodicCheck.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_fault_int_to_str : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faults_Equipment_EquipmentId",
                table: "Faults");

            migrationBuilder.AlterColumn<string>(
                name: "Fault_Name",
                table: "FaultNames",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Faults_Equipment_EquipmentId",
                table: "Faults",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faults_Equipment_EquipmentId",
                table: "Faults");

            migrationBuilder.AlterColumn<int>(
                name: "Fault_Name",
                table: "FaultNames",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Faults_Equipment_EquipmentId",
                table: "Faults",
                column: "EquipmentId",
                principalTable: "Equipment",
                principalColumn: "EquipmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
