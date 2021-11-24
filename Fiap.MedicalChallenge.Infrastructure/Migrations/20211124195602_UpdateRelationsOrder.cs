using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.MedicalChallenge.Infrastructure.Migrations
{
    public partial class UpdateRelationsOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Orders_DrugStorageId",
                table: "Orders",
                column: "DrugStorageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DrugStorages_DrugStorageId",
                table: "Orders",
                column: "DrugStorageId",
                principalTable: "DrugStorages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DrugStorages_DrugStorageId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DrugStorageId",
                table: "Orders");
        }
    }
}
