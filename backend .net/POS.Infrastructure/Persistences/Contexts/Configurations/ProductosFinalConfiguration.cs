using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class ProductosFinalConfiguration
    {
        public void Configure(EntityTypeBuilder<ProductosFinal> builder)
        {
            builder.ToTable("ProductosFinal", tb => tb.HasTrigger("TR_CalcularMargen"));

            builder.HasIndex(e => e.CategoriaId, "IX_ProductosFinal_CategoriaId");

            builder.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.MargenGanancia).HasColumnType("decimal(5, 2)");
            builder.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");
        }
    }
}
