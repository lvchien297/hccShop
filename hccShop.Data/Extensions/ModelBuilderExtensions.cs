using hccShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace hccShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of HccShop" },
                new AppConfig() { Key = "HomeKeyWord", Value = "This is home keyword of HccShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is home description of HccShop" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Điện thoại", IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Enums.Status.Active, },
                new Category() { Id = 2, Name = "Laptop", IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Enums.Status.Active, },
                new Category() { Id = 3, Name = "Camera", IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Enums.Status.Active, }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Iphone 5s",
                    DateCreated = DateTime.Now,
                    OriginalPrice = 2000000,
                    Price = 2100000,
                    Stock = 0,
                    ViewCount = 0,
                        
                },
                new Product()
                {
                    Id =2,
                    Name = "Iphone 6",
                    DateCreated = DateTime.Now,
                    OriginalPrice = 1500000,
                    Price = 2000000,
                    Stock = 0,
                    ViewCount = 0,
                }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                ) ;

        }
    }
}
