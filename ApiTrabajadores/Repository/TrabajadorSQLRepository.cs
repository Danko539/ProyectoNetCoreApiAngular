using ApiTrabajadores.DbContexts;
using ApiTrabajadores.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTrabajadores.Repository
{
    public class TrabajadorSQLRepository : ITrabajadorRepository
    {
        private AppDbContext dbContext;
        public TrabajadorSQLRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<Trabajador> AddTrabajador(Trabajador trabajador)
        {
            dbContext.Trabajadors.Add(trabajador);
            await dbContext.SaveChangesAsync();

            return trabajador;
        }

        public async Task<bool> DeleteTrabajador(int id)
        {
            var trabajador = await dbContext.Trabajadors.FirstOrDefaultAsync(t => t.trabajadorId == id);

            if(trabajador == null)
            {
                return false;
            }

            dbContext.Trabajadors.Remove(trabajador);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Trabajador> GetTrabajadorById(int id)
        {
            var trabajador = await dbContext.Trabajadors.Where(t => t.trabajadorId == id)
                                                        .FirstOrDefaultAsync();

            return trabajador;
        }

        public async Task<IEnumerable<Trabajador>> GetTrabajadores()
        {
            return await dbContext.Trabajadors.ToListAsync();
        }

        public async Task<Trabajador> UpdateTrabajador(Trabajador trabajador)
        {
            dbContext.Trabajadors.Update(trabajador);
            await dbContext.SaveChangesAsync();

            return trabajador;
        }
    }
}
