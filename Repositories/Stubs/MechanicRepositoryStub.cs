using System.Collections.Generic;
using System.Linq;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class MechanicRepositoryStub : IMechanicRepository
    {
        private readonly List<Mechanic> _mechanics = new List<Mechanic>();
        private int _nextId = 1;

        public List<Mechanic> GetAll() => _mechanics;

        public Mechanic GetById(int id) => _mechanics.FirstOrDefault(m => m.Id == id);

        public void Add(Mechanic mechanic)
        {
            mechanic.SetId(_nextId++);
            _mechanics.Add(mechanic);
        }

        public void Update(Mechanic mechanic)
        {
            var existing = GetById(mechanic.Id);
            if (existing != null)
            {
                int index = _mechanics.IndexOf(existing);
                _mechanics[index] = mechanic;
            }
        }

        public void Delete(int id)
        {
            var mechanic = GetById(id);
            if (mechanic != null) _mechanics.Remove(mechanic);
        }
    }
}