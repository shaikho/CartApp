using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CartApp.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cartId = table.Column<Guid>(type: "char(36)", nullable: false),
                    totalPrice = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cartId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<Guid>(type: "char(36)", nullable: false),
                    price = table.Column<double>(type: "double", nullable: false),
                    description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    category = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    availableQuantity = table.Column<int>(type: "int", nullable: false),
                    cartId = table.Column<int>(type: "int", nullable: false),
                    cartId1 = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_Carts_cartId1",
                        column: x => x.cartId1,
                        principalTable: "Carts",
                        principalColumn: "cartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_cartId1",
                table: "Products",
                column: "cartId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
