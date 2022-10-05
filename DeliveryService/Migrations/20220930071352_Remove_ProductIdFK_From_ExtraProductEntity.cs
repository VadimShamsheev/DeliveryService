using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryService.Migrations
{
    public partial class Remove_ProductIdFK_From_ExtraProductEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraProducts_Products_ProductId",
                table: "ExtraProducts");

            migrationBuilder.DropIndex(
                name: "IX_ExtraProducts_ProductId",
                table: "ExtraProducts");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ExtraProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ExtraProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExtraProducts_ProductId",
                table: "ExtraProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraProducts_Products_ProductId",
                table: "ExtraProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
