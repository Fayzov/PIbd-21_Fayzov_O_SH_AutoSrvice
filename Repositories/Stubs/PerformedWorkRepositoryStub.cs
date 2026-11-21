using System.Collections.Generic;
using System.Linq;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class PerformedWorkRepositoryStub : IPerformedWorkRepository
    {
        private readonly List<PerformedWork> _works = new List<PerformedWork>();
        private int _nextId = 1;

        public List<PerformedWork> GetAll() => _works;

        public void Add(PerformedWork performedWork)
        {
            performedWork.SetId(_nextId++);
            _works.Add(performedWork);
        }

        public void Delete(int id)
        {
            var work = _works.FirstOrDefault(w => w.Id == id);
            if (work != null) _works.Remove(work);
        }
    }
}