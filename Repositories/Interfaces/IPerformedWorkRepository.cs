using System.Collections.Generic;
using AutoService.Models;

namespace AutoService.Repositories.Interfaces
{
    public interface IPerformedWorkRepository
    {
        List<PerformedWork> GetAll();
        void Add(PerformedWork performedWork);
        void Delete(int id);
    }
}