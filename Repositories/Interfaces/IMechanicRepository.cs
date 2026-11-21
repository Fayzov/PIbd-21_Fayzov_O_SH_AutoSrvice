using System.Collections.Generic;
using AutoService.Models;

namespace AutoService.Repositories.Interfaces
{
    public interface IMechanicRepository
    {
        List<Mechanic> GetAll();
        Mechanic GetById(int id);
        void Add(Mechanic mechanic);
        void Update(Mechanic mechanic);
        void Delete(int id);
    }
}