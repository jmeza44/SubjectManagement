using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface IScheduledClassRepository
    {
        ScheduledClass AddScheduledClass(ScheduledClass scheduledClass);
        ScheduledClass DeleteScheduledClass(int id);
        List<ScheduledClass> GetAllScheduledClasses();
        ScheduledClass GetScheduledClass(int id);
        List<ScheduledClass> GetScheduledClassesOf(int subjectId);
        Classroom GetRelatedClassroom(int scheduledClassID);
        ScheduledClass UpdateScheduledClass(int id, ScheduledClass scheduledClass);
    }
}