using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IProductosRepository
    {
        Task<List<ProductosFinal>> GetAll();
        Task<ProductosFinal> ProductById(int productId);
        Task<bool> RegisterClient(ProductosFinal product);
        Task<bool> EditClient(ProductosFinal product);
        Task<bool> RemoveClient(int productId);
    }
}
