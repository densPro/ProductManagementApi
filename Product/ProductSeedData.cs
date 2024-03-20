using Microsoft.EntityFrameworkCore;

namespace ProductManagementApi.Product
{
    public static class ProductSeedData
    {
        public static void InitializeProducts(ModelBuilder modelBuilder)
        {
            var products = new[]
            {
                new ProductEntity { Id = 1, Name = "Smartphone", Price = 599.99m },
                new ProductEntity { Id = 2, Name = "Laptop", Price = 999.99m },
                new ProductEntity { Id = 3, Name = "Smartwatch", Price = 199.99m },
                new ProductEntity { Id = 4, Name = "Wireless Earbuds", Price = 79.99m },
                new ProductEntity { Id = 5, Name = "Digital Camera", Price = 499.99m },
                new ProductEntity { Id = 6, Name = "4K TV", Price = 799.99m },
                new ProductEntity { Id = 7, Name = "Gaming Console", Price = 399.99m },
                new ProductEntity { Id = 8, Name = "Fitness Tracker", Price = 129.99m },
                new ProductEntity { Id = 9, Name = "Tablet", Price = 299.99m },
                new ProductEntity { Id = 10, Name = "Headphones", Price = 149.99m },
                new ProductEntity { Id = 11, Name = "Smart Home Hub", Price = 129.99m },
                new ProductEntity { Id = 12, Name = "Robot Vacuum", Price = 249.99m },
                new ProductEntity { Id = 13, Name = "Coffee Maker", Price = 69.99m },
                new ProductEntity { Id = 14, Name = "Bluetooth Speaker", Price = 49.99m },
                new ProductEntity { Id = 15, Name = "Wireless Charger", Price = 29.99m },
                new ProductEntity { Id = 16, Name = "Drone", Price = 799.99m },
                new ProductEntity { Id = 17, Name = "E-book Reader", Price = 119.99m },
                new ProductEntity { Id = 18, Name = "Portable Power Bank", Price = 29.99m },
                new ProductEntity { Id = 19, Name = "External Hard Drive", Price = 89.99m },
                new ProductEntity { Id = 20, Name = "Action Camera", Price = 149.99m }
            };

            modelBuilder.Entity<ProductEntity>().HasData(products);
        }
    }
}