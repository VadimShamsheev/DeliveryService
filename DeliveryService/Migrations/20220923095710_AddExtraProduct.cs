using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryService.Migrations
{
    public partial class AddExtraProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "OrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderProducts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "OrderProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
