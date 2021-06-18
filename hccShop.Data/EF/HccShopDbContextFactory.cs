using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace hccShop.Data.EF
{
    public class HccShopDbContextFactory : IDesignTimeDbContextFactory<HccShopDbContext>
    {
        public HccShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("hccShopDb");
            var optionsBuilder = new DbContextOptionsBuilder<HccShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HccShopDbContext(optionsBuilder.Options);
        }
    }
}
