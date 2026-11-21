using System.Collections.Generic;
using System.Linq;
using AutoService.Models;
using AutoService.Repositories.Interfaces;

namespace AutoService.Repositories.Stubs
{
    public class WorkTypeRepositoryStub : IWorkTypeRepository
    {
        private readonly List<WorkType> _workTypes = new List<WorkType>();
        private int _nextId = 1;

        public List<WorkType> GetAll() => _workTypes;

        public WorkType GetById(int id) => _workTypes.FirstOrDefault(w => w.Id == id);

        public void Add(WorkType workType)
        {
            workType.SetId(_nextId++);
            _workTypes.Add(workType);
        }

        public void Update(WorkType workType)
        {
            var existing = GetById(workType.Id);
            if (existing != null)
            {
                int index = _workTypes.IndexOf(existing);
                _workTypes[index] = workType;
            }
        }

        public void Delete(int id)
        {
            var workType = GetById(id);
            if (workType != null) _workTypes.Remove(workType);
        }
    }
}