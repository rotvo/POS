﻿using POS.Domain.Entities;
using POS.Infrastructure.Commons.Bases.Response;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IClientsRepository
    {
        Task<List<Client>> GetAll();
        Task<Client> ClientById(int clientId);
        Task<bool> RegisterClient(Client client);
        Task<bool> EditClient(Client client);
        Task<bool>RemoveClient(int ClientId);
    }
}