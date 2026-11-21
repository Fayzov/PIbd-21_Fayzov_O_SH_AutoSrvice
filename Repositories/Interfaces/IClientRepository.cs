using System.Collections.Generic;
using AutoService.Models;

namespace AutoService.Repositories.Interfaces
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(int id);
        void Add(Client client);
        void Update(Client client);
        void Delete(int id);
    }
}