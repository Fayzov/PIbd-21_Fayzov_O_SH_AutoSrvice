using System.Collections.Generic;
using System.Linq;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class UsedPartRepositoryStub : IUsedPartRepository
    {
        private readonly List<UsedPart> _usedParts = new List<UsedPart>();
        private int _nextId = 1;

        public List<UsedPart> GetAll() => _usedParts;

        public void Add(UsedPart usedPart)
        {
            usedPart.SetId(_nextId++);
            _usedParts.Add(usedPart);
        }

        public void Delete(int id)
        {
            var part = _usedParts.FirstOrDefault(p => p.Id == id);
            if (part != null) _usedParts.Remove(part);
        }
    }
}