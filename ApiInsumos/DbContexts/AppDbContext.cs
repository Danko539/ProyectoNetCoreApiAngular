using ApiInsumos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiInsumos.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
           
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Insumo> Insumos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                          .AddJsonFile("appsettings.json")
                                                          .Build();

            var connectionString = configuration.GetConnectionString("InsumosDB");

                optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
