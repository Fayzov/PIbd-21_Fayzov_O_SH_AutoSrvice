using System.Collections.Generic;
using AutoService.Models;

namespace AutoService.Repositories.Interfaces
{
    public interface IWorkTypeRepository
    {
        List<WorkType> GetAll();
        WorkType GetById(int id);
        void Add(WorkType workType);
        void Update(WorkType workType);
        void Delete(int id);
    }
}