using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryService.Migrations
{
    public partial class AddCart_AddCartProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Clients_ClientId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraProducts_OrderProducts_ProductInCartId",
                table: "ExtraProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Cart_CartId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cart_CartId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "OrderProducts",
                newName: "CartProduct");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_ProductId",
                table: "CartProduct",
                newName: "IX_CartProduct_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_CartId",
                table: "CartProduct",
                newName: "IX_CartProduct_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_ClientId",
                table: "Carts",
                newName: "IX_Carts_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Carts_CartId",
                table: "CartProduct",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartProduct_Products_ProductId",
                table: "CartProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Clients_ClientId",
                table: "Carts",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExtraProducts_CartProduct_ProductInCartId",
                table: "ExtraProducts",
                column: "ProductInCartId",
                principalTable: "CartProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Carts_CartId",
                table: "Orders",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Carts_CartId",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CartProduct_Products_ProductId",
                table: "CartProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Clients_ClientId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_ExtraProducts_CartProduct_ProductInCartId",
                table: "ExtraProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Carts_CartId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProduct",
                table: "CartProduct");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameTable(
                name: "CartProduct",
                newName: "OrderProducts");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ClientId",
                table: "Cart",
                newName: "IX_Cart_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_CartProduct_ProductId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_CartProduct_CartId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Clients_ClientId",
                table: "Cart",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_OrderProducts_Products_ProductId",
                table: "OrderProducts",
                column: "ProductId",
                principalTable: "Products",
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
    }
}
