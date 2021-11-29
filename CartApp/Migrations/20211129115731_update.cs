using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartApp.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cartId", "totalPrice" },
                values: new object[] { new Guid("acb22d7c-347d-4fe2-8222-a14498817f49"), 0.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "availableQuantity", "cartId", "category", "description", "price" },
                values: new object[,]
                {
                    { new Guid("22d4939a-0376-4bd6-aa59-60b55447afbd"), 100, new Guid("acb22d7c-347d-4fe2-8222-a14498817f49"), "Clothes", "Blue shirt", 100.0 },
                    { new Guid("f24f9b4c-dbed-45d2-b75e-79e513a9080f"), 140, new Guid("acb22d7c-347d-4fe2-8222-a14498817f49"), "Clothes", "Red pants", 100.0 },
                    { new Guid("3d9b4939-b0fc-4157-a99c-5cb10912af63"), 500, new Guid("acb22d7c-347d-4fe2-8222-a14498817f49"), "Accessories", "Earings", 100.0 },
                    { new Guid("ce278e37-4746-485e-b5fb-8efdc9c12411"), 1000, new Guid("acb22d7c-347d-4fe2-8222-a14498817f49"), "Accessories", "Glasses", 100.0 },
                    { new Guid("2937f765-4672-4f59-b61e-3032c3f4b9a8"), 50, new Guid("acb22d7c-347d-4fe2-8222-a14498817f49"), "Clothes", "Hat", 100.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("22d4939a-0376-4bd6-aa59-60b55447afbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("2937f765-4672-4f59-b61e-3032c3f4b9a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("3d9b4939-b0fc-4157-a99c-5cb10912af63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("ce278e37-4746-485e-b5fb-8efdc9c12411"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("f24f9b4c-dbed-45d2-b75e-79e513a9080f"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "cartId",
                keyValue: new Guid("acb22d7c-347d-4fe2-8222-a14498817f49"));

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
        }
    }
}
