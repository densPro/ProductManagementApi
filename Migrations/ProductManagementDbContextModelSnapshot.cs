﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductManagementApi;

#nullable disable

namespace ProductManagementApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class ProductManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductManagementApi.Product.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Stay connected with the latest technology in your hands. Our smartphone offers top-of-the-line features and sleek design.",
                            Name = "Smartphone",
                            Price = 599.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Boost your productivity with our high-performance laptop. Perfect for work, entertainment, and everything in between.",
                            Name = "Laptop",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Stay active and organized with our smartwatch. Track your fitness goals, receive notifications, and more, all from your wrist.",
                            Name = "Smartwatch",
                            Price = 199.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Experience true freedom with our wireless earbuds. Enjoy crystal-clear sound and hands-free convenience on the go.",
                            Name = "Wireless Earbuds",
                            Price = 79.99m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Capture life's moments in stunning detail with our digital camera. Whether you're a beginner or a professional, our camera has you covered.",
                            Name = "Digital Camera",
                            Price = 499.99m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Immerse yourself in a world of entertainment with our 4K TV. Experience vibrant colors, sharp contrast, and lifelike images from the comfort of your home.",
                            Name = "4K TV",
                            Price = 799.99m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Take your gaming experience to the next level with our gaming console. Play the latest titles, stream your favorite content, and connect with friends online.",
                            Name = "Gaming Console",
                            Price = 399.99m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Achieve your fitness goals with our fitness tracker. Monitor your activity, track your workouts, and stay motivated on your journey to a healthier lifestyle.",
                            Name = "Fitness Tracker",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Experience versatility and portability with our tablet. Whether you're working, browsing, or streaming, our tablet adapts to your needs.",
                            Name = "Tablet",
                            Price = 299.99m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Immerse yourself in music with our headphones. Enjoy crisp, clear sound and comfortable listening for hours on end.",
                            Name = "Headphones",
                            Price = 149.99m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Transform your home into a smart home with our smart home hub. Control your devices, automate your routines, and enhance your living space with ease.",
                            Name = "Smart Home Hub",
                            Price = 129.99m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Simplify your cleaning routine with our robot vacuum. Sit back, relax, and let our vacuum do the work for you, leaving your floors spotless.",
                            Name = "Robot Vacuum",
                            Price = 249.99m
                        },
                        new
                        {
                            Id = 13,
                            Description = "Start your day off right with our coffee maker. Brew your favorite blend to perfection and enjoy a delicious cup of coffee every time.",
                            Name = "Coffee Maker",
                            Price = 69.99m
                        },
                        new
                        {
                            Id = 14,
                            Description = "Enhance your listening experience with our Bluetooth speaker. Whether you're at home or on the go, enjoy rich, immersive sound wherever you are.",
                            Name = "Bluetooth Speaker",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 15,
                            Description = "Simplify charging with our wireless charger. Say goodbye to tangled cords and enjoy effortless charging for your compatible devices.",
                            Name = "Wireless Charger",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = 16,
                            Description = "Explore the skies and capture stunning aerial footage with our drone. Whether you're a hobbyist or a professional, our drone delivers unparalleled performance and versatility.",
                            Name = "Drone",
                            Price = 799.99m
                        },
                        new
                        {
                            Id = 17,
                            Description = "Immerse yourself in a world of books with our e-book reader. Enjoy thousands of titles at your fingertips, anytime, anywhere.",
                            Name = "E-book Reader",
                            Price = 119.99m
                        },
                        new
                        {
                            Id = 18,
                            Description = "Stay powered up on the go with our portable power bank. Never worry about running out of battery again, whether you're traveling, commuting, or exploring.",
                            Name = "Portable Power Bank",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = 19,
                            Description = "Keep your files safe and secure with our external hard drive. Whether you're storing documents, photos, or videos, our hard drive has ample storage for all your needs.",
                            Name = "External Hard Drive",
                            Price = 89.99m
                        },
                        new
                        {
                            Id = 20,
                            Description = "Capture life's adventures in stunning detail with our action camera. Whether you're hiking, biking, or snorkeling, our camera is built to withstand the elements and capture every moment.",
                            Name = "Action Camera",
                            Price = 149.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
