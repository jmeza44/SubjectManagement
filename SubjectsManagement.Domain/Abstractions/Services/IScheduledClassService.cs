using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface IScheduledClassService
    {
        ScheduledClass AddScheduledClass(ScheduledClassDto scheduledClassDto);
        ScheduledClass DeleteScheduledClass(int id);
        List<ScheduledClass> GetAllScheduledClassess();
        ScheduledClass GetScheduledClass(int id);
        ScheduledClass UpdateScheduledClass(int id, ScheduledClassDto scheduledClassDto);
    }
}
