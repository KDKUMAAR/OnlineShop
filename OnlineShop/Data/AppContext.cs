using Microsoft.EntityFrameworkCore;
using OnlineShop.Data.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class AppContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity() { Id = 1, ProductName = "Product 1", Description = "Test Description", ImagePath = @"/images/mobile_1.jpg", Price = 300 },
                new ProductEntity() { Id = 2, ProductName = "Product 2", Description = "Test Description", ImagePath = @"/images/mobile_2.jpg", Price = 400 },
                new ProductEntity() { Id = 3, ProductName = "Product 3", Description = "Test Description", ImagePath = @"/images/mobile_3.jpg", Price = 500 },
                new ProductEntity() { Id = 4, ProductName = "Product 4", Description = "Test Description", ImagePath = @"/images/mobile_4.jpg", Price = 600 }
               );
            base.OnModelCreating(modelBuilder);
        }

    }
}
