using ApiProveedores.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProveedores.DbContexts
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Proveedor> Proveedors { get; set; }
    }
}
