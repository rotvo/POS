namespace POS.Application.Dtos.Response
{
    public class ProductResponseDto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public decimal Costo { get; set; }
        public int CategoriaId { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal MargenGanancia { get; set; }

    }
}
