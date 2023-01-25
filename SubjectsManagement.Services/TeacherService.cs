using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Abstractions.Services;
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

        public Teacher AddTeacher(TeacherDto teacherDto)
        {
            var teacher = _repo.AddTeacher((Teacher)teacherDto);
            return teacher;
        }

        public Teacher DeleteTeacher(int id)
        {
            var teacher = _repo.DeleteTeacher(id);
            return teacher;
        }

        public List<Teacher> GetAllTeachers()
        {
            var teachers = _repo.GetAllTeachers();
            return teachers;
        }

        public Teacher GetTeacher(int id)
        {
            var teacher = _repo.GetTeacher(id);
            return teacher;
        }

        public Teacher UpdateTeacher(int id, TeacherDto teacherDto)
        {
            var teacher = _repo.UpdateTeacher(id, (Teacher)teacherDto);
            return teacher;
        }
    }
}
