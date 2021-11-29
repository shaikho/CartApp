using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartApp.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_cartId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_cartId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "cartId1",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "cartId",
                table: "Products",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cartId", "totalPrice" },
                values: new object[] { new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"), 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "availableQuantity", "cartId", "category", "description", "price" },
                values: new object[,]
                {
                    { new Guid("db6a0a67-5420-46a5-829e-a56f6ac47775"), 100, new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"), "Clothes", "Blue shirt", 100.0 },
                    { new Guid("eb762a6f-dd00-4278-ad75-24c71b3cad31"), 140, new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"), "Clothes", "Red pants", 100.0 },
                    { new Guid("5b50d9b9-c7df-412e-b0bc-abd63e91a3e0"), 500, new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"), "Accessories", "Earings", 100.0 },
                    { new Guid("6d447128-fe46-4e60-be65-74cc684b1820"), 1000, new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"), "Accessories", "Glasses", 100.0 },
                    { new Guid("d7d49396-cfbb-478a-950a-086c1a3cb2cb"), 50, new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"), "Clothes", "Hat", 100.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_cartId",
                table: "Products",
                column: "cartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_cartId",
                table: "Products",
                column: "cartId",
                principalTable: "Carts",
                principalColumn: "cartId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Carts_cartId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_cartId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("5b50d9b9-c7df-412e-b0bc-abd63e91a3e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("6d447128-fe46-4e60-be65-74cc684b1820"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("d7d49396-cfbb-478a-950a-086c1a3cb2cb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("db6a0a67-5420-46a5-829e-a56f6ac47775"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("eb762a6f-dd00-4278-ad75-24c71b3cad31"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cartId",
                keyValue: new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"));

            migrationBuilder.AlterColumn<int>(
                name: "cartId",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AddColumn<Guid>(
                name: "cartId1",
                table: "Products",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_cartId1",
                table: "Products",
                column: "cartId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Carts_cartId1",
                table: "Products",
                column: "cartId1",
                principalTable: "Carts",
                principalColumn: "cartId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
