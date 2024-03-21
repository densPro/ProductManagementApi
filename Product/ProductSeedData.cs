using Microsoft.EntityFrameworkCore;

namespace ProductManagementApi.Product
{
    public static class ProductSeedData
    {
        public static void InitializeProducts(ModelBuilder modelBuilder)
        {
            var products = new[]
            {
                new ProductEntity { Id = 1, Name = "Smartphone", Price = 599.99m, Description = "Stay connected with the latest technology in your hands. Our smartphone offers top-of-the-line features and sleek design." },
                new ProductEntity { Id = 2, Name = "Laptop", Price = 999.99m, Description = "Boost your productivity with our high-performance laptop. Perfect for work, entertainment, and everything in between." },
                new ProductEntity { Id = 3, Name = "Smartwatch", Price = 199.99m, Description = "Stay active and organized with our smartwatch. Track your fitness goals, receive notifications, and more, all from your wrist." },
                new ProductEntity { Id = 4, Name = "Wireless Earbuds", Price = 79.99m, Description = "Experience true freedom with our wireless earbuds. Enjoy crystal-clear sound and hands-free convenience on the go." },
                new ProductEntity { Id = 5, Name = "Digital Camera", Price = 499.99m, Description = "Capture life's moments in stunning detail with our digital camera. Whether you're a beginner or a professional, our camera has you covered." },
                new ProductEntity { Id = 6, Name = "4K TV", Price = 799.99m, Description = "Immerse yourself in a world of entertainment with our 4K TV. Experience vibrant colors, sharp contrast, and lifelike images from the comfort of your home." },
                new ProductEntity { Id = 7, Name = "Gaming Console", Price = 399.99m, Description = "Take your gaming experience to the next level with our gaming console. Play the latest titles, stream your favorite content, and connect with friends online." },
                new ProductEntity { Id = 8, Name = "Fitness Tracker", Price = 129.99m, Description = "Achieve your fitness goals with our fitness tracker. Monitor your activity, track your workouts, and stay motivated on your journey to a healthier lifestyle." },
                new ProductEntity { Id = 9, Name = "Tablet", Price = 299.99m, Description = "Experience versatility and portability with our tablet. Whether you're working, browsing, or streaming, our tablet adapts to your needs." },
                new ProductEntity { Id = 10, Name = "Headphones", Price = 149.99m, Description = "Immerse yourself in music with our headphones. Enjoy crisp, clear sound and comfortable listening for hours on end." },
                new ProductEntity { Id = 11, Name = "Smart Home Hub", Price = 129.99m, Description = "Transform your home into a smart home with our smart home hub. Control your devices, automate your routines, and enhance your living space with ease." },
                new ProductEntity { Id = 12, Name = "Robot Vacuum", Price = 249.99m, Description = "Simplify your cleaning routine with our robot vacuum. Sit back, relax, and let our vacuum do the work for you, leaving your floors spotless." },
                new ProductEntity { Id = 13, Name = "Coffee Maker", Price = 69.99m, Description = "Start your day off right with our coffee maker. Brew your favorite blend to perfection and enjoy a delicious cup of coffee every time." },
                new ProductEntity { Id = 14, Name = "Bluetooth Speaker", Price = 49.99m, Description = "Enhance your listening experience with our Bluetooth speaker. Whether you're at home or on the go, enjoy rich, immersive sound wherever you are." },
                new ProductEntity { Id = 15, Name = "Wireless Charger", Price = 29.99m, Description = "Simplify charging with our wireless charger. Say goodbye to tangled cords and enjoy effortless charging for your compatible devices." },
                new ProductEntity { Id = 16, Name = "Drone", Price = 799.99m, Description = "Explore the skies and capture stunning aerial footage with our drone. Whether you're a hobbyist or a professional, our drone delivers unparalleled performance and versatility." },
                new ProductEntity { Id = 17, Name = "E-book Reader", Price = 119.99m, Description = "Immerse yourself in a world of books with our e-book reader. Enjoy thousands of titles at your fingertips, anytime, anywhere." },
                new ProductEntity { Id = 18, Name = "Portable Power Bank", Price = 29.99m, Description = "Stay powered up on the go with our portable power bank. Never worry about running out of battery again, whether you're traveling, commuting, or exploring." },
                new ProductEntity { Id = 19, Name = "External Hard Drive", Price = 89.99m, Description = "Keep your files safe and secure with our external hard drive. Whether you're storing documents, photos, or videos, our hard drive has ample storage for all your needs." },
                new ProductEntity { Id = 20, Name = "Action Camera", Price = 149.99m, Description = "Capture life's adventures in stunning detail with our action camera. Whether you're hiking, biking, or snorkeling, our camera is built to withstand the elements and capture every moment." }
            };

            modelBuilder.Entity<ProductEntity>().HasData(products);
        }
    }
}