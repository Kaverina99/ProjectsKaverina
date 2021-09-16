using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
namespace RealtyProg.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RealtyContext>
    {
        public RealtyContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new
            ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new
            DbContextOptionsBuilder<RealtyContext>();
            var connectionString =
            configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new RealtyContext(builder.Options); 
        }
    }
}
