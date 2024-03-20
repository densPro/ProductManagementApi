using Microsoft.EntityFrameworkCore;
using ProductManagementApi.Product;

namespace ProductManagementApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }
        // Add more DbSet properties for other entities as needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductSeedData.InitializeProducts(modelBuilder);
        }
    }
}