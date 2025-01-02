using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistences.Contexts;
using POS.Infrastructure.Persistences.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Repositories
{
    public class ClientsRepository : GenericRepository<Client>, IClientsRepository
    {
        private readonly DbFloreria2Context _context;

        public ClientsRepository(DbFloreria2Context context)
        {
            _context = context;
        }

      

       

        public  Task<List<Client>> GetAll()
        {
            Console.WriteLine("Starting GetAll method");

            try
            {
                var response =  _context.Clientes.ToListAsync();
                Console.WriteLine("Query completed");
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }


        public async Task<bool> RegisterClient(Client client)
        {
            await _context.AddAsync(client);
            var recordsAffected = await _context.SaveChangesAsync();

            return recordsAffected > 0;
        }
        public async Task<bool> EditClient(Client client)
        {
  
            _context.Update(client);
            _context.Entry(client);
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;
        }


        public async Task<bool> RemoveClient(int ClientId)
        {
            var client = await _context.Clientes.AsNoTracking().SingleOrDefaultAsync(x => x.Id.Equals(ClientId));
            _context.Remove(client);
            var recordsAffected = await _context.SaveChangesAsync();
            return recordsAffected > 0;

        }

        public async Task<Client> ClientById(int clientId)
        {
            return await _context.Clientes.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(clientId));

        }

        
    }
}
