using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface ITeacherRepository
    {
        Teacher AddTeacher(Teacher teacher);
        Teacher DeleteTeacher(int id);
        List<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
        Teacher UpdateTeacher(int id, Teacher teacher);
    }
}
