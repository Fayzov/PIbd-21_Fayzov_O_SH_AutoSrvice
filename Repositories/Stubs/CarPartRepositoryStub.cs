using System.Collections.Generic;
using System.Linq;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class CarPartRepositoryStub : ICarPartRepository
    {
        private readonly List<CarPart> _carParts = new List<CarPart>();
        private int _nextId = 1;

        public List<CarPart> GetAll() => _carParts;

        public CarPart GetById(int id) => _carParts.FirstOrDefault(p => p.Id == id);

        public void Add(CarPart carPart)
        {
            carPart.SetId(_nextId++);
            _carParts.Add(carPart);
        }

        public void Update(CarPart carPart)
        {
            var existing = GetById(carPart.Id);
            if (existing != null)
            {
                int index = _carParts.IndexOf(existing);
                _carParts[index] = carPart;
            }
        }

        public void Delete(int id)
        {
            var carPart = GetById(id);
            if (carPart != null) _carParts.Remove(carPart);
        }
    }
}