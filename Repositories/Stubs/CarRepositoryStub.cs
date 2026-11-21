using System.Collections.Generic;
using System.Linq;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class CarRepositoryStub : ICarRepository
    {
        private readonly List<Car> _cars = new List<Car>();
        private int _nextId = 1;

        public List<Car> GetAll() => _cars;

        public Car GetById(int id) => _cars.FirstOrDefault(c => c.Id == id);

        public void Add(Car car)
        {
            car.SetId(_nextId++);
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var existing = GetById(car.Id);
            if (existing != null)
            {
                int index = _cars.IndexOf(existing);
                _cars[index] = car;
            }
        }

        public void Delete(int id)
        {
            var car = GetById(id);
            if (car != null) _cars.Remove(car);
        }
    }
}