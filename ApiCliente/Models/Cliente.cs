namespace ApiCliente.Models
{
    public class Cliente
    {
        public int clienteId { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? celular { get; set; }
        public string? direccion { get; set; }
        public string? email { get; set; }
    }
}
