using ApiSecciones.Models;

namespace ApiSecciones.Repository
{
    public interface ISeccionRepository
    {
        Task<IEnumerable<Seccion>> GetSecciones();
        Task<Seccion> GetSeccionById(int id);
        Task<Seccion> AddSeccion(Seccion seccion);
        Task<Seccion> UpdateSeccion(Seccion seccion);
        Task<bool> DeleteSeccion(int id);
    }
}
