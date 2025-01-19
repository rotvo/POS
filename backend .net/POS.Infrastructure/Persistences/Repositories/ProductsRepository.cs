using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class ProductsRepository: GenericRepository<ProductosFinal>, IProductosRepository
    {
        private readonly DbFloreria2Context _context;

        public ProductsRepository(DbFloreria2Context context)
        {
            _context = context;
        }
        public Task<List<ProductosFinal>> GetAll()
        {
            Console.WriteLine("Starting GetAll method");

            try
            {
                var response = _context.ProductosFinal.ToListAsync();
                Console.WriteLine("Query completed");
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        public Task<bool> EditClient(ProductosFinal product)
        {
            throw new NotImplementedException();
        }

       

        public Task<ProductosFinal> ProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterClient(ProductosFinal product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveClient(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
