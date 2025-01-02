using System;
using System.Collections.Generic;

namespace POS.Domain.Entities;

public partial class Client
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public long? NumeroWhatsapp { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
