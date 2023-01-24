using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface ITeacherService
    {
        OperationResult<Teacher> AddTeacher(TeacherDto teacherDto);
        OperationResult<Teacher> DeleteTeacher(int id);
        OperationResult<List<Teacher>> GetAllTeachers();
        OperationResult<Teacher> GetTeacher(int id);
        OperationResult<Teacher> UpdateTeacher(int id, TeacherDto teacherDto);
    }
}
