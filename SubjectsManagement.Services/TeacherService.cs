using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repo;
        public TeacherService(ITeacherRepository repo)
        {
            _repo = repo;
        }

        public OperationResult<Teacher?> AddTeacher(TeacherDto teacherDto)
        {
            var teacher = _repo.AddTeacher((Teacher)teacherDto);
            return new AddedOperationResult<Teacher?>(teacher, "Teacher");
        }

        public OperationResult<Teacher?> DeleteTeacher(int id)
        {

            var teacher = _repo.DeleteTeacher(id);
            return new DeletedOperationResult<Teacher?>(teacher, "Teacher", id);
        }

        public OperationResult<List<Teacher>> GetAllTeachers()
        {
            var teachers = _repo.GetAllTeachers();
            return new GetAllOperationResult<List<Teacher>>(teachers, "Teacher", teachers.Count);
        }

        public OperationResult<Teacher?> GetTeacher(int id)
        {
            var teacher = _repo.GetTeacher(id);
            return new GetOperationResult<Teacher?>(teacher, "Teacher", id);
        }

        public OperationResult<Teacher?> UpdateTeacher(int id, TeacherDto teacherDto)
        {
            var teacher = _repo.UpdateTeacher(id, (Teacher)teacherDto);
            return new UpdateOperationResult<Teacher?>(teacher, "Teacher", id);
        }
    }
}
