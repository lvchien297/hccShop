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
            //modelBuilder.Entity<AppConfig>().HasData(
            //    new AppConfig() { Key = "HomeTitle", Value = "This is home page of HccShop" },
            //    new AppConfig() { Key = "HomeKeyWord", Value = "This is home keyword of HccShop" },
            //    new AppConfig() { Key = "HomeDescription", Value = "This is home description of HccShop" }
            //    );
            //modelBuilder.Entity<Category>().HasData(
            //    new Category() { name = "", IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Enums.Status.Active, },
            //    new Category() { },
            //    new Category() { }
            //    );

        }
    }
}
