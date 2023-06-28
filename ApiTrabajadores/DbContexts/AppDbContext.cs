using ApiTrabajadores.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTrabajadores.DbContexts
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Trabajador> Trabajadors { get; set; }
    }
}
