using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface ISubjectService
    {
        void AssignSemester(Semester semester);
        void AssignTeacher(Teacher teacher);
    }
}
