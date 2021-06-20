using hccShop.Data.Entities;
using hccShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
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
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
               );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true }
            //new Language() { Id = "en-US", Name = "English", IsDefault = false }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 3,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 3,
                    Status = Status.Active
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Điện thoại", LanguageId = "vi-VN", SeoAlias = "dien-thoai", },
                  new CategoryTranslation() { Id = 2, CategoryId = 2, Name = "Laptop", LanguageId = "vi-VN", SeoAlias = "laptop", },
                  new CategoryTranslation() { Id = 3, CategoryId = 3, Name = "Camera", LanguageId = "vi-VN", SeoAlias = "camera", }
                 );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreated = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           },
           new Product()
           {
               Id = 2,
               DateCreated = DateTime.Now,
               OriginalPrice = 10000000,
               Price = 15000000,
               Stock = 0,
               ViewCount = 0,
           }
           );
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Điện thoại Bphone 3",
                     LanguageId = "vi-VN",
                     SeoAlias = "dien-thoai-bphone3",

                     Details = "Điện thoại Bphone 3",
                     Description = "Điện thoại Bphone 3"
                 },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Điện thoại Bphone 2",
                    LanguageId = "vi-VN",
                    SeoAlias = "dien-thoai-bphone2",

                    Details = "Điện thoại Bphone 2",
                    Description = "Điện thoại Bphone 2"
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );

            var roleId = new Guid("E4C5F58A-33E5-4F05-8283-6CD2CBBC0A3F");
            var adminId = new Guid("F3E3F26D-B4F0-4EF2-AB2C-E90B694C1061");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "hccShop@gmail.com",
                NormalizedEmail = "hccShop@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Chien",
                LastName = "Le",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
