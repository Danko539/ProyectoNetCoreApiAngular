using ApiTrabajadores.Models;

namespace ApiTrabajadores.Repository
{
    public interface ITrabajadorRepository
    {
        Task<IEnumerable<Trabajador>> GetTrabajadores();
        Task<Trabajador> GetTrabajadorById(int id);
        Task<Trabajador> AddTrabajador(Trabajador trabajador);
        Task<Trabajador> UpdateTrabajador(Trabajador trabajador);
        Task<bool> DeleteTrabajador(int id);
    }
}
