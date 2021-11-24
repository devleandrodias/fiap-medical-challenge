using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.MedicalChallenge.Infrastructure.Migrations
{
    public partial class AddStatusOnPrescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Prescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Prescriptions");
        }
    }
}
