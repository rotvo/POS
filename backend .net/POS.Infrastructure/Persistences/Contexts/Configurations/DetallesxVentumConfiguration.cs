using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class DetallesxVentumConfiguration : IEntityTypeConfiguration<DetallesxVentum>
    {
        public void Configure(EntityTypeBuilder<DetallesxVentum> builder)
        {
            builder.HasIndex(e => e.ProductoFinalId, "IX_DetallesxVenta_ProductoFinalId");

            builder.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            builder.HasOne(d => d.ProductoFinal).WithMany(p => p.DetallesxVenta).HasForeignKey(d => d.ProductoFinalId);
        }
    }
}
