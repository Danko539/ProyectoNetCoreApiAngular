using ApiCliente.Models;
using ApiCliente.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiCliente.Controllers
{
    [ApiController]
    [Route("/api/cliente")]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        [HttpGet]
        [Route("/GetClientes")]
        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await clienteRepository.GetClientes();  
        }

        [HttpGet]
        [Route("/GetClienteById/{id}")]
        public async Task<Cliente> GetClienteById(int id)
        {
            return await clienteRepository.GetClienteById(id);
        }

        [HttpDelete]
        [Route("/DeleteCliente/{id}")]
        public async Task<bool> DeleteCliente(int id)
        {
            return await clienteRepository.DeleteCliente(id);
        }

        [HttpPost]
        [Route("/Createcliente")]
        public async Task<Cliente> Createcliente(Cliente cliente)
        {
            return await clienteRepository.AddCliente(cliente);
        }

        [HttpPut]
        [Route("/UpdateCliente")]
        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            return await clienteRepository.UpdateCliente(cliente);
        }
    } 
}
