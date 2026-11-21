using System.Collections.Generic;
using System.Linq;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class ClientRepositoryStub : IClientRepository
    {
        private readonly List<Client> _clients = new List<Client>();
        private int _nextId = 1;

        public List<Client> GetAll() => _clients;

        public Client GetById(int id) => _clients.FirstOrDefault(c => c.Id == id);

        public void Add(Client client)
        {
            client.SetId(_nextId++);
            _clients.Add(client);
        }

        public void Update(Client client)
        {
            var existing = GetById(client.Id);
            if (existing != null)
            {
                int index = _clients.IndexOf(existing);
                _clients[index] = client;
            }
        }

        public void Delete(int id)
        {
            var client = GetById(id);
            if (client != null) _clients.Remove(client);
        }
    }
}