namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClientsRepository Clients { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
