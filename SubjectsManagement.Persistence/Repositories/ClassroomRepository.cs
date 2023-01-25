using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class ClassroomRepository : IClassroomRepository
    {
        private readonly AppDbContext _context;
        public ClassroomRepository(AppDbContext context)
        {
            _context = context;
        }

        public Classroom AddClassroom(Classroom classroom)
        {
            var _classroom = _context.Add(classroom);
            _context.SaveChanges();
            return _classroom.Entity;
        }

        public Classroom DeleteClassroom(int id)
        {
            var _classroom = _context.Classrooms.FirstOrDefault(c => c.Id == id);
            if (_classroom != null)
            {
                _context.Classrooms.Remove(_classroom);
                _context.SaveChanges();
            }
            return _classroom;
        }

        public List<Classroom> GetAllClassrooms()
        {
            return _context.Classrooms.ToList();
        }

        public Classroom GetClassroom(int id)
        {
            var _classroom = _context.Classrooms.FirstOrDefault(c => c.Id == id);
            return _classroom;
        }

        public Classroom UpdateClassroom(int id, Classroom classroom)
        {
            var _classroom = _context.Classrooms.FirstOrDefault(c => c.Id == id);
            if (_classroom != null)
            {
                _classroom.RoomName = classroom.RoomName;
                _classroom.Building = classroom.Building;
                _context.SaveChanges();
            }
            return _classroom;
        }
    }
}
