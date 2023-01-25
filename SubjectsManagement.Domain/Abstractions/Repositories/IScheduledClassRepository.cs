using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface IScheduledClassRepository
    {
        ScheduledClass AddScheduledClass(ScheduledClass scheduledClass);
        ScheduledClass DeleteScheduledClass(int id);
        List<ScheduledClass> GetAllScheduledClassess();
        ScheduledClass GetScheduledClass(int id);
        ScheduledClass UpdateScheduledClass(int id, ScheduledClass scheduledClass);
    }
}