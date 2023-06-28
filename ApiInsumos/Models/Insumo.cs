using System.ComponentModel.DataAnnotations;

namespace ApiInsumos.Models
{
    public class Insumo
    {
        [Key]
        public int insumoId { get; set; }

        [Required]
        public string? nombre { get; set; }
        public string? tipo { get; set; }
        public string? descripcion { get; set; }

        [Range(1,1000)]
        public double precio { get; set; }
        public string? imagenUrl { get; set; }
        public string? seccionCode { get; set; }
    }
}
