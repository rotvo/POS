using System;
using System.Collections.Generic;

namespace POS.Domain.Entities;

public partial class Insumo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal? Costo { get; set; }

    public int? UnidadesPorPaquete { get; set; }

    public decimal? CostoUnitario { get; set; }

    public int? ProveedorId { get; set; }

    public int? Stock { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public virtual ICollection<InsumosXproducto> InsumosXproductos { get; set; } = new List<InsumosXproducto>();

    public virtual Proveedor? Proveedor { get; set; }
}
