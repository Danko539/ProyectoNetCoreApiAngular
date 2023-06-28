using ApiCliente.DbContexts;
using ApiCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.Repository
{
    public class ClienteSQLRepository : IClienteRepository
    {
        private AppDbContext dbContext;
        public ClienteSQLRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            dbContext.Clients.Add(cliente);
            await dbContext.SaveChangesAsync();

            return cliente;
        }

        public async Task<bool> DeleteCliente(int id)
        {
            var cliente = await dbContext.Clients.FirstOrDefaultAsync(c => c.clienteId == id);

            if(cliente == null)
            {
                return false;
            }

            dbContext.Clients.Remove(cliente);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            var cliente = await dbContext.Clients.Where(c => c.clienteId == id).FirstOrDefaultAsync();

            return cliente;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await dbContext.Clients.ToListAsync();
        }

        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            dbContext.Clients.Update(cliente);
            await dbContext.SaveChangesAsync();

            return cliente;
        }
    }
}
