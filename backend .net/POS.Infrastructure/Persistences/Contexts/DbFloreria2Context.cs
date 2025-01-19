using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;
using System.Reflection;

namespace POS.Infrastructure.Persistences.Contexts;

public partial class DbFloreria2Context : DbContext
{
    public DbFloreria2Context()
    {
    }

    public DbFloreria2Context(DbContextOptions<DbFloreria2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Client> Clientes { get; set; }

    public virtual DbSet<DetallesxVentum> DetallesxVenta { get; set; }

    public virtual DbSet<Insumo> Insumos { get; set; }

    public virtual DbSet<InsumosXproducto> InsumosXproductos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<ProductosFinal> ProductosFinal { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
