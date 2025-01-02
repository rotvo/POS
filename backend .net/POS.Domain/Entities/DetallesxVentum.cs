using System;
using System.Collections.Generic;

namespace POS.Domain.Entities;

public partial class DetallesxVentum
{
    public int Id { get; set; }

    public int? VentaId { get; set; }

    public int? ProductoFinalId { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Total { get; set; }

    public virtual ProductosFinal? ProductoFinal { get; set; }
}
