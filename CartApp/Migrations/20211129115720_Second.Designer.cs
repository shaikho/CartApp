// <auto-generated />
using System;
using CartApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CartApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211129115720_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CartApp.Models.Cart", b =>
                {
                    b.Property<Guid>("cartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double>("totalPrice")
                        .HasColumnType("double");

                    b.HasKey("cartId");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            cartId = new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"),
                            totalPrice = 0.0
                        });
                });

            modelBuilder.Entity("CartApp.Models.Product", b =>
                {
                    b.Property<Guid>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("availableQuantity")
                        .HasColumnType("int");

                    b.Property<Guid>("cartId")
                        .HasColumnType("char(36)");

                    b.Property<string>("category")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.HasKey("productId");

                    b.HasIndex("cartId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            productId = new Guid("db6a0a67-5420-46a5-829e-a56f6ac47775"),
                            availableQuantity = 100,
                            cartId = new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"),
                            category = "Clothes",
                            description = "Blue shirt",
                            price = 100.0
                        },
                        new
                        {
                            productId = new Guid("eb762a6f-dd00-4278-ad75-24c71b3cad31"),
                            availableQuantity = 140,
                            cartId = new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"),
                            category = "Clothes",
                            description = "Red pants",
                            price = 100.0
                        },
                        new
                        {
                            productId = new Guid("5b50d9b9-c7df-412e-b0bc-abd63e91a3e0"),
                            availableQuantity = 500,
                            cartId = new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"),
                            category = "Accessories",
                            description = "Earings",
                            price = 100.0
                        },
                        new
                        {
                            productId = new Guid("6d447128-fe46-4e60-be65-74cc684b1820"),
                            availableQuantity = 1000,
                            cartId = new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"),
                            category = "Accessories",
                            description = "Glasses",
                            price = 100.0
                        },
                        new
                        {
                            productId = new Guid("d7d49396-cfbb-478a-950a-086c1a3cb2cb"),
                            availableQuantity = 50,
                            cartId = new Guid("21f544e3-5587-4d1b-bc1e-c3ca928a0208"),
                            category = "Clothes",
                            description = "Hat",
                            price = 100.0
                        });
                });

            modelBuilder.Entity("CartApp.Models.Product", b =>
                {
                    b.HasOne("CartApp.Models.Cart", null)
                        .WithMany("products")
                        .HasForeignKey("cartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CartApp.Models.Cart", b =>
                {
                    b.Navigation("products");
                });
#pragma warning restore 612, 618
        }
    }
}
