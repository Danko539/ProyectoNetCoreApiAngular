using ApiProveedores.Models;
using ApiProveedores.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiProveedores.Controllers
{
    [ApiController]
    [Route("/api/proveedor")]
    public class ProveedorController : ControllerBase
    {
        private IProveedorRepository proveedorRepository;
        public ProveedorController(IProveedorRepository proveedorRepository)
        {
            this.proveedorRepository = proveedorRepository;
        }


        [HttpGet]
        [Route("/GetProveedores")]
        public async Task<IEnumerable<Proveedor>> GetProveedores()
        {
            return await proveedorRepository.GetProveedores();
        }

        [HttpGet]
        [Route("/GetProveedorById/{id}")]
        public async Task<Proveedor> GetProveedorById(int id)
        {
            return await proveedorRepository.GetProveedorById(id);
        }

        [HttpDelete]
        [Route("/DeleteProveedor/{id}")]
        public async Task<bool> DeleteProveedor(int id)
        {
            return await proveedorRepository.DeleteProveedor(id);
        }

        [HttpPost]
        [Route("/CreateProveedor")]
        public async Task<Proveedor> CreateProveedor(Proveedor proveedor)
        {
            return await proveedorRepository.AddProveedor(proveedor);
        }

        [HttpPut]
        [Route("/UpdateProveedor")]
        public async Task<Proveedor> UpdateProveedor(Proveedor proveedor)
        {
            return await proveedorRepository.UpdateProveedor(proveedor);
        }
    }
}
