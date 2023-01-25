using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface ITeacherService
    {
        Teacher AddTeacher(TeacherDto teacherDto);
        Teacher DeleteTeacher(int id);
        List<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
        Teacher UpdateTeacher(int id, TeacherDto teacherDto);
    }
}
