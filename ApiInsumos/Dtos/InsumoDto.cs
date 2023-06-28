namespace ApiInsumos.Dtos
{
    public class InsumoDto
    {
        public int insumoId { get; set; }
        public string? nombre { get; set; }
        public string? tipo { get; set; }
        public string? descripcion { get; set; }
        public double precio { get; set; }
        public string? imagenUrl { get; set; }
        public string? seccionCode { get; set; }
    }
}
