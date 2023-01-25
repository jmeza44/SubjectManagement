using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _context;
        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }

        public Teacher AddTeacher(Teacher teacher)
        {
            var teacherAdded = _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacherAdded.Entity;
        }

        public Teacher DeleteTeacher(int id)
        {
            var teacherDelete = _context.Teachers.FirstOrDefault(c => c.Id == id);
            if (teacherDelete != null)
            {
                _context.Teachers.Remove(teacherDelete);
                _context.SaveChanges();
            }
            return teacherDelete;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacher(int id)
        {
            var teacher = _context.Teachers.FirstOrDefault(c => c.Id == id);
            return teacher;
        }

        public Teacher UpdateTeacher(int id, Teacher teacher)
        {
            var teacherUpdate = _context.Teachers.FirstOrDefault(c => c.Id == id);
            if (teacherUpdate != null)
            {
                teacherUpdate.Name = teacher.Name;
                teacherUpdate.PhoneNumber = teacher.PhoneNumber;
                teacherUpdate.Email = teacher.Email;
                _context.SaveChanges();
            }
            return teacherUpdate;
        }
    }
}
