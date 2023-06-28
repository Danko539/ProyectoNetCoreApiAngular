using ApiProveedores.Models;

namespace ApiProveedores.Repository
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> GetProveedores();
        Task<Proveedor> GetProveedorById(int id);
        Task<Proveedor> AddProveedor(Proveedor proveedor);
        Task<Proveedor> UpdateProveedor(Proveedor proveedor);
        Task<bool> DeleteProveedor(int id);
    }
}
