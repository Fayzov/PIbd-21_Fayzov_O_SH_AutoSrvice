using System.Collections.Generic;
using AutoService.Models;

namespace AutoService.Repositories.Interfaces
{
    public interface IUsedPartRepository
    {
        List<UsedPart> GetAll();
        void Add(UsedPart usedPart);
        void Delete(int id);
    }
}