using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class PedidoConfiguration
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasIndex(e => e.ClienteId, "IX_Pedidos_ClienteId");

            builder.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Cliente).WithMany(p => p.Pedidos).HasForeignKey(d => d.ClienteId);
        }
    }
}
