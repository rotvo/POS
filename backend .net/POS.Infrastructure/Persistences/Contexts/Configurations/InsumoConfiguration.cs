using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class InsumoConfiguration
    {
        public void Configure(EntityTypeBuilder<InsumosXproducto> builder)
        {
            builder.ToTable("InsumosXProductos");

            builder.HasIndex(e => e.InsumoId, "IX_InsumosXProductos_InsumoId");

            builder.HasIndex(e => e.ProductoFinalId, "IX_InsumosXProductos_ProductoFinalId");

            builder.Property(e => e.CantidadInsumo).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.Insumo).WithMany(p => p.InsumosXproductos).HasForeignKey(d => d.InsumoId);

            builder.HasOne(d => d.ProductoFinal).WithMany(p => p.InsumosXproductos).HasForeignKey(d => d.ProductoFinalId);
        }
    }
}
