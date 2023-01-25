using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface IScheduledClassService
    {
        ScheduledClass AddScheduledClass(ScheduledClassDto scheduledClassDto);
        ScheduledClass DeleteScheduledClass(int id);
        List<ScheduledClass> GetAllScheduledClasses();
        ScheduledClass GetScheduledClass(int id);
        List<ScheduledClass> GetScheduledClassesOf(int subjectId);
        Classroom GetRelatedClassroom(int scheduledClassId);
        ScheduledClass UpdateScheduledClass(int id, ScheduledClassDto scheduledClassDto);
    }
}
