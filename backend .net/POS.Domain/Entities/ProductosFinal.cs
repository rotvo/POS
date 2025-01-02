namespace POS.Domain.Entities;

public partial class ProductosFinal
{
    public int Id { get; set; }

    public string NombreProducto { get; set; } = null!;

    public bool? EsActivo { get; set; }

    public decimal? Costo { get; set; }

    public decimal? Factor { get; set; }

    public int? CategoriaId { get; set; }

    public decimal? PrecioVenta { get; set; }

    public virtual Categoria? Categoria { get; set; }

    public virtual ICollection<DetallesxVentum> DetallesxVenta { get; set; } = new List<DetallesxVentum>();

    public virtual ICollection<InsumosXproducto> InsumosXproductos { get; set; } = new List<InsumosXproducto>();
}
