using ApiSecciones.Models;
using ApiSecciones.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiSecciones.Controllers
{
    [ApiController]
    [Route("/api/seccion")]
    public class SeccionController : ControllerBase
    {
        private ISeccionRepository seccionRepository;
        public SeccionController(ISeccionRepository seccionRepository)
        {
            this.seccionRepository = seccionRepository;
        }

        [HttpGet]
        [Route("/GetSecciones")]
        public async Task<IEnumerable<Seccion>> GetSecciones()
        {
            return await seccionRepository.GetSecciones();
        }

        [HttpGet]
        [Route("/GetSeccionById/{id}")]
        public async Task<Seccion> GetSeccionById(int id)
        {
            return await seccionRepository.GetSeccionById(id);
        }

        [HttpDelete]
        [Route("/DeleteSeccion/{id}")]
        public async Task<bool> DeleteSeccion(int id)
        {
            return await seccionRepository.DeleteSeccion(id);
        }

        [HttpPost]
        [Route("/CreateSeccion")]
        public async Task<Seccion> CreateSeccion(Seccion seccion)
        {
            return await seccionRepository.AddSeccion(seccion);
        }

        [HttpPut]
        [Route("/UpdateSeccion")]
        public async Task<Seccion> UpdateSeccion(Seccion seccion)
        {
            return await seccionRepository.UpdateSeccion(seccion);
        }
    }
}
