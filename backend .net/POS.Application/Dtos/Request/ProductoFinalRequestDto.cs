using POS.Domain.Entities;

namespace POS.Application.Dtos.Request
{
    public class ProductoFinalRequestDto
    {
        public string NombreProducto { get; set; } = null!;

        public bool? EsActivo { get; set; }

        public decimal? Costo { get; set; }

        public decimal? Factor { get; set; }

        public int? CategoriaId { get; set; }   

        public decimal? PrecioVenta { get; set; }
    }
}
