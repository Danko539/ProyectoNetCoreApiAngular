using ApiProveedores.DbContexts;
using ApiProveedores.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProveedores.Repository
{
    public class ProveedorSQLRepository : IProveedorRepository
    {
        private AppDbContext dbContext;
        public ProveedorSQLRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<Proveedor> AddProveedor(Proveedor proveedor)
        {
            dbContext.Proveedors.Add(proveedor);
            await dbContext.SaveChangesAsync();

            return proveedor;
        }

        public async Task<bool> DeleteProveedor(int id)
        {
            var proveedor = await dbContext.Proveedors.FirstOrDefaultAsync(p => p.proveedorId == id);

            if (proveedor == null)
            {
                return false;
            }

            dbContext.Proveedors.Remove(proveedor);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Proveedor> GetProveedorById(int id)
        {
            var proveedor = await dbContext.Proveedors.Where(p => p.proveedorId == id).FirstOrDefaultAsync();

            return proveedor;
        }

        public async Task<IEnumerable<Proveedor>> GetProveedores()
        {
            return await dbContext.Proveedors.ToListAsync();
        }

        public async Task<Proveedor> UpdateProveedor(Proveedor proveedor)
        {
            dbContext.Proveedors.Update(proveedor);
            await dbContext.SaveChangesAsync();

            return proveedor;
        }
    }
}
