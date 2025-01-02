using System;
using System.Collections.Generic;

namespace POS.Domain.Entities;

public partial class Categoria
{
    public int Id { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public virtual ICollection<ProductosFinal> ProductosFinals { get; set; } = new List<ProductosFinal>();
}
