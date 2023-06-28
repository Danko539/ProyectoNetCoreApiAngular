using ApiSecciones.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSecciones.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<Seccion> seccions { get; set; }
    }
}
