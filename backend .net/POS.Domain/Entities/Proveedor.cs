using System;
using System.Collections.Generic;

namespace POS.Domain.Entities;

public partial class Proveedor
{
    public int Id { get; set; }

    public string? NombreProveedor { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Insumo> Insumos { get; set; } = new List<Insumo>();
}
