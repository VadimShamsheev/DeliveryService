using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DeliveryService.Migrations
{
    public partial class AddRestaurant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address_City = table.Column<string>(nullable: true),
                    Address_Street = table.Column<string>(nullable: true),
                    Address_HouseNumber = table.Column<string>(nullable: true),
                    Address_Entrance = table.Column<int>(nullable: true),
                    Address_Floor = table.Column<int>(nullable: true),
                    Address_ApartmentNumber = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RestId",
                table: "Orders",
                column: "RestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Restaurant_RestId",
                table: "Orders",
                column: "RestId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Restaurant_RestId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RestId",
                table: "Orders");
        }
    }
}
