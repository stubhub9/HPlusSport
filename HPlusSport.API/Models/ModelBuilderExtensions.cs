using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {
        //  EntityFrameworkCore.ModelBuilder
        public static void Seed ( this ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Category> ().HasData (
                new Category { Id = 1, Name = "ActiveWear - Men" },
                new Category { Id = 2, Name = "ActiveWear - Women" },
                new Category { Id = 3, Name = "ActiveWear - Mineral Water" },
                new Category { Id = 4, Name = "ActiveWear - Publications" },
                new Category { Id = 5, Name = "ActiveWear - Supplements" } );


            modelBuilder.Entity<Product> ().HasData (
                new Product
                {
                    Id = 1,
                    Sku = "AWMGSJ",
                    CategoryId = 1,
                    Name = "Grunge Skater Jeans",
                    Price = 68,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 2,
                    Sku = "AWMPS",
                    CategoryId = 1,
                    Name = "Polo Shirt",
                    Price = 35,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Sku= "AWMSGT",
                    Name = "Skater Graphic T-Shirt",
                    Price = 33,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 4,
                    Sku = "AWMSJ",
                    CategoryId = 1,
                    Name = "Slicker Jacket",
                    Price = 125,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 5,
                    Sku = "AWMTFJ",
                    CategoryId = 1,
                    Name = "Thermal Fleece Jacket",
                    Price = 120,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 6,
                    Sku = "AWMUCS",
                    CategoryId = 1,
                    Name = "Unisex Cheap Shirt",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 7,
                    Sku = "AWMVNP",
                    CategoryId = 1,
                    Name = "V-Neck Pullover",
                    Price = 64,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 8,
                    Sku = "AWMVNS",
                    CategoryId = 1,
                    Name = "V-Neck Sweater",
                    Price = 65,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 9,
                    Sku = "AWMVNT",
                    CategoryId = 1,
                    Name = "V-Neck T-Shirt",
                    Price = 26,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 10,
                    Sku = "AWMBTSC",
                    CategoryId = 2,
                    Name = "Bamboo Thermal Ski Coat",
                    Price = 96,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 11,
                    Sku = "AWMCBTT",
                    CategoryId = 2,
                    Name = "Cross-Back Training Tank",
                    Price = 16,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 12,
                    CategoryId = 2,
                    Name = "Grunge Shirt",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 13,
                    CategoryId = 2,
                    Name = "Slicker Shirt",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 14,
                    CategoryId = 2,
                    Name = "Stretchy Shirt",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 15,
                    CategoryId = 2,
                    Name = "Ultra-Soft Shirt",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 16,
                    CategoryId = 2,
                    Name = "Unisex Shirt",
                    Price = 35,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 17,
                    CategoryId = 2,
                    Name = "V-Neck Shirt",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 18,
                    Sku = "MWB",
                    CategoryId = 3,
                    Name = "Blueberry",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 19,
                    Sku = "MWLL",
                    CategoryId = 3,
                    Name = "Lemon-Lime",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 20,
                    Sku = "MWO",
                    CategoryId = 3,
                    Name = "Orange",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 21,
                    Sku = "MWP",
                    CategoryId = 3,
                    Name = "Peach",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 22,
                    Sku = "MWR",
                    CategoryId = 3,
                    Name = "Raspberry",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 23,
                    Sku = "MWS",
                    CategoryId = 3,
                    Name = "Strawberry",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 24,
                    Sku = "PBITM",
                    CategoryId = 4,
                    Name = "In the Mood",
                    Price = 20,
                    IsAvailable = false
                },
                new Product
                {
                    Id = 25,
                    Sku = "SVCA",
                    CategoryId = 5,
                    Name = "Calcium",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 26,
                    Sku = "SVFS",
                    CategoryId = 5,
                    Name = "Flaxseed",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 27,
                    Sku = "SVI",
                    CategoryId = 5,
                    Name = "Iron",
                    Price = 8,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 28,
                    Sku = "SVM",
                    CategoryId = 5,
                    Name = "Magnesium",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 29,
                    Sku = "SVMV",
                    CategoryId = 5,
                    Name = "Multi-Vitamin",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 30,
                    Sku = "SVA",
                    CategoryId = 5,
                    Name = "Vitamin A",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 31,
                    Sku = "SVB",
                    CategoryId = 5,
                    Name = "Vitamin B",
                    Price = 8,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 32,
                    Sku = "SVC",
                    CategoryId = 5,
                    Name = "Vitamin C",
                    Price = 6,
                    IsAvailable = true
                },
                new Product
                {
                    Id = 33,
                    Sku = "SVD",
                    CategoryId = 5,
                    Name = "Vitamin D",
                    Price = 6,
                    IsAvailable = true
                }
                );





        }
    }
}
