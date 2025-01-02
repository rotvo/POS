using System;
using System.Collections.Generic;

namespace POS.Domain.Entities;

public partial class InsumosXproducto
{
    public int Id { get; set; }

    public int? InsumoId { get; set; }

    public int? ProductoFinalId { get; set; }

    public decimal? CantidadInsumo { get; set; }

    public virtual Insumo? Insumo { get; set; }

    public virtual ProductosFinal? ProductoFinal { get; set; }
}
