namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClientsRepository Clients { get; }
        IProductosRepository Productos { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
