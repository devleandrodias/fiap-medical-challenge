using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.MedicalChallenge.Infrastructure.Migrations
{
    public partial class AddStatusOnOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");
        }
    }
}
