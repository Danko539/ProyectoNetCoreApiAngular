using ApiSecciones.DbContexts;
using ApiSecciones.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSecciones.Repository
{
    public class SeccionSQLRepository : ISeccionRepository
    {
        private AppDbContext dbContext;
        public SeccionSQLRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<Seccion> AddSeccion(Seccion seccion)
        {
            dbContext.seccions.Add(seccion);
            await dbContext.SaveChangesAsync();

            return seccion;
        }

        public async Task<bool> DeleteSeccion(int id)
        {
            var seccion = await dbContext.seccions.FirstOrDefaultAsync(s => s.seccionId == id);

            if(seccion == null)
            {
                return false;
            }

            dbContext.seccions.Remove(seccion);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Seccion> GetSeccionById(int id)
        {
            var seccion = await dbContext.seccions.Where(s => s.seccionId == id).FirstOrDefaultAsync();

            return seccion;
        }

        public async Task<IEnumerable<Seccion>> GetSecciones()
        {
            return await dbContext.seccions.ToListAsync();
        }

        public async Task<Seccion> UpdateSeccion(Seccion seccion)
        {
            dbContext.seccions.Update(seccion);
            await dbContext.SaveChangesAsync();

            return seccion;
        }
    }
}
