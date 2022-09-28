using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DeliveryService.Migrations
{
    public partial class ChangeExtraProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExtraProducts",
                table: "ExtraProducts");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "OrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrderProducts",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "OrderProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ExtraCount",
                table: "ExtraProducts",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "ProductInCartId",
                table: "ExtraProducts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExtraProducts",
                table: "ExtraProducts",
                column: "ProductInCartId");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CartId",
                table: "Orders",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_CartId",
                table: "OrderProducts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraProducts_ExtraId",
                table: "ExtraProducts",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ClientId",
                table: "Cart",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraProducts_OrderProducts_ProductInCartId",
                table: "ExtraProducts",
                column: "ProductInCartId",
                principalTable: "OrderProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Cart_CartId",
                table: "OrderProducts",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cart_CartId",
                table: "Orders",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExtraProducts_OrderProducts_ProductInCartId",
                table: "ExtraProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Cart_CartId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cart_CartId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CartId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderProducts_CartId",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExtraProducts",
                table: "ExtraProducts");

            migrationBuilder.DropIndex(
                name: "IX_ExtraProducts_ExtraId",
                table: "ExtraProducts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "ProductInCartId",
                table: "ExtraProducts");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "OrderProducts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ExtraCount",
                table: "ExtraProducts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExtraProducts",
                table: "ExtraProducts",
                columns: new[] { "ExtraId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_OrderId",
                table: "OrderProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
