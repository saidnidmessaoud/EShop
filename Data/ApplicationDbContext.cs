using EShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Daily Laptop" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Gaming Laptop" });
            builder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "2-in-1 Laptop" });

            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 1,
                Name = "HP",
                Price = 8990M,
                Description = "HP - PC PORT MATEBOOK D15 I5-1135G7 512G - INTEL CORE I5",
                CategoryId = 1,
                ImageUrl = "\\Images\\1.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\1.png",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 2,
                Name = "ACER",
                Price = 9299M,
                Description = "ACER _ SWFT 3 I5-1135G7 512G W10 GRIS _ INTEL CORE I5 ",
                CategoryId = 1,
                ImageUrl = "\\Images\\2.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\2.png",
                IsOnRecommend = false,
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 3,
                Name = "LENOVO",
                Price = 13499M,
                Description = "LENOVO 8 YOGA 6 _AMD - AMD RYZEN 7 5700U",
                CategoryId = 1,
                ImageUrl = "\\Images\\3.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\3.png",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 4,
                Name = "MSI",
                Price = 11799M,
                Description = "MSI _ GF63 I5-11400H _INTEL CORE I5 - 11TH GEN INTEL®CORE\u0099",
                CategoryId = 2,
                ImageUrl = "\\Images\\4.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\4.png",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 5,
                Name = "ACER",
                Price = 19999M,
                Description = "ACER _ PDTR I7-11800H16G512GRTX3060 NOIR _ - INTEL CORE I7",
                CategoryId = 2,
                ImageUrl = "\\Images\\5.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\5.png",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 6,
                Name = "APPLE",
                Price = 23413M,
                Description = "APPLE _ MACBOOK AIR MLXX3FN/A M2 512 GO _ APPLE M2 8-CORE",
                CategoryId = 2,
                ImageUrl = "\\Images\\6.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\6.png",
                IsOnRecommend = false
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 7,
                Name = "APPLE",
                Price = 45990M,
                Description = "APPLE _ MACBOOK PRO M1 MAX 1TSSD 16\" SILVER _ CPU 10 C\u009cURS",
                CategoryId = 3,
                ImageUrl = "\\Images\\7.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\7.png",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 8,
                Name = "LENOVO",
                Price = 7000M,
                Description = "LENOVO _ IDEAPAD FLEX 5 _ AMD _ AMD RYZEN\u0099 3 5300U",
                CategoryId = 3,
                ImageUrl = "\\Images\\8.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\8.png",
                IsOnRecommend = true
            });
            builder.Entity<Computer>().HasData(new Computer
            {
                ComputerId = 9,
                Name = "ASUS",
                Price = 13999M,
                Description = "ASUS _ N7400 I5 SILVER _ INTEL CORE I5",
                CategoryId = 3,
                ImageUrl = "\\Images\\9.png",
                ImageThumbnailUrl = "\\Images\\thumbnails\\9.png",
                IsOnRecommend = false
            });

        }
    }
}
