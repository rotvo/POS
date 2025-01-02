using System;
using System.Collections.Generic;

namespace POS.Domain.Entities;

public partial class Pedido
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public string? Municipio { get; set; }

    public string? Direccion { get; set; }

    public DateOnly? FechaPedido { get; set; }

    public DateOnly? FechaEntrega { get; set; }

    public string? Estatus { get; set; }

    public decimal? Total { get; set; }

    public string? Detalles { get; set; }

    public string? MensajeTarjeta { get; set; }

    public TimeOnly? HoraEntrega { get; set; }

    public virtual Client? Cliente { get; set; }
}
