using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class ScheduledClassService : IScheduledClassService
    {
        private readonly IScheduledClassRepository _repo;

        public ScheduledClassService(IScheduledClassRepository repo)
        {
            _repo = repo;
        }

        public ScheduledClass AddScheduledClass(ScheduledClassDto scheduledClassDto)
        {
            var scheduledClass = _repo.AddScheduledClass((ScheduledClass)scheduledClassDto);
            return scheduledClass;
        }

        public ScheduledClass DeleteScheduledClass(int id)
        {
            var scheduledClass = _repo.DeleteScheduledClass(id);
            return scheduledClass;
        }

        public List<ScheduledClass> GetAllScheduledClassess()
        {
            var scheduledClasses = _repo.GetAllScheduledClassess();
            return scheduledClasses;
        }

        public ScheduledClass GetScheduledClass(int id)
        {
            var scheduledClass = _repo.GetScheduledClass(id);
            return scheduledClass;
        }

        public ScheduledClass UpdateScheduledClass(int id, ScheduledClassDto scheduledClassDto)
        {
            var scheduledClass = _repo.UpdateScheduledClass(id, (ScheduledClass)scheduledClassDto);
            return scheduledClass;
        }
    }
}
