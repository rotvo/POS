using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbFloreria2Context _context;
        public IClientsRepository Clients { get; private set;}

        public IProductosRepository Productos { get; private set; }

        public UnitOfWork(DbFloreria2Context context)
        {
            _context = context;
            Clients = new ClientsRepository(_context);
            Productos = new ProductsRepository(_context);
        }
        public void Dispose()
        {
           _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
