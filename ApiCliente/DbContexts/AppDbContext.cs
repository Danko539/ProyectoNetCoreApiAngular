using ApiCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.DbContexts
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cliente> Clients { get; set; } 
    }
}
