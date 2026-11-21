using System.Collections.Generic;
using AutoService.Models;

namespace AutoService.Repositories.Interfaces
{
    public interface ICarPartRepository
    {
        List<CarPart> GetAll();
        CarPart GetById(int id);
        void Add(CarPart carPart);
        void Update(CarPart carPart);
        void Delete(int id);
    }
}