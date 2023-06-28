namespace ApiTrabajadores.Models
{
    public class Trabajador
    {
        public int trabajadorId { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? numeroCelular { get; set; }
        public string? correo { get; set; }
        public string? direccion { get; set; }
        public string? dni { get; set; }
        public double sueldo { get; set; }
    }
}
