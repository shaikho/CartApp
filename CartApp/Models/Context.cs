using Microsoft.EntityFrameworkCore;
using System;

namespace CartApp.Models
{
    public class Context : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Product> Products { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid cartid = new Guid();
            cartid = Guid.NewGuid();

            modelBuilder.Entity<Cart>()
                .HasData(new Cart { cartId = cartid, products = null, totalPrice = 0.0 });

            modelBuilder.Entity<Product>()
                .HasData(new Product { productId = Guid.NewGuid(), price = 200.0, description = "Blue shirt", category = "Clothes", availableQuantity = 100, cartId = cartid });
            modelBuilder.Entity<Product>()
                .HasData(new Product { productId = Guid.NewGuid(), price = 1000.0, description = "Red pants", category = "Clothes", availableQuantity = 140, cartId = cartid });
            modelBuilder.Entity<Product>()
                .HasData(new Product { productId = Guid.NewGuid(), price = 10000.0, description = "Earings", category = "Accessories", availableQuantity = 500, cartId = cartid });
            modelBuilder.Entity<Product>()
                .HasData(new Product { productId = Guid.NewGuid(), price = 400.0, description = "Glasses", category = "Accessories", availableQuantity = 1000, cartId = cartid });
            modelBuilder.Entity<Product>()
                .HasData(new Product { productId = Guid.NewGuid(), price = 150.0, description = "Hat", category = "Clothes", availableQuantity = 50, cartId = cartid });
        }
    }
}
