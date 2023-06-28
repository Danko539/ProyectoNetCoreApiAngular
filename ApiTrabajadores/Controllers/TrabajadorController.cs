using ApiTrabajadores.Models;
using ApiTrabajadores.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiTrabajadores.Controllers
{
    [ApiController]
    [Route("/api/trabajador")]
    public class TrabajadorController : ControllerBase
    {
        private ITrabajadorRepository trabajadorRepository;
        public TrabajadorController(ITrabajadorRepository trabajadorRepository)
        {
            this.trabajadorRepository = trabajadorRepository;
        }


        [HttpGet]
        [Route("/GetTrabajador")]
        public async Task<IEnumerable<Trabajador>> GetTrabajadores()
        {
            return await trabajadorRepository.GetTrabajadores();
        }

        [HttpGet]
        [Route("/GetTrabajadorById/{id}")]
        public async Task<Trabajador> GetTrabajadorById(int id)
        {
            return await trabajadorRepository.GetTrabajadorById(id);
        }

        [HttpDelete]
        [Route("/DeleteTrabajador/{id}")]
        public async Task<bool> DeleteTrabajador(int id)
        {
            return await trabajadorRepository.DeleteTrabajador(id);
        }

        [HttpPost]
        [Route("/CreateTrabajador")]
        public async Task<Trabajador> CreateTrabajador(Trabajador trabajador)
        {
            return await trabajadorRepository.AddTrabajador(trabajador);
        }

        [HttpPut]
        [Route("/UpdateTrabajador")]
        public async Task<Trabajador> UpdateTrabajador(Trabajador trabajador)
        {
            return await trabajadorRepository.UpdateTrabajador(trabajador);
        }
    }
}
