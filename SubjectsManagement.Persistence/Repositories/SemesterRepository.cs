using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class SemesterRepository : ISemesterRepository
    {
        private readonly AppDbContext _context;
        public SemesterRepository(AppDbContext context)
        {
            _context = context;
        }

        public Semester AddSemester(Semester semester)
        {
            var semesterAdded = _context.Semesters.Add(semester);
            _context.SaveChanges();
            return semesterAdded.Entity;
        }

        public Semester DeleteSemester(int id)
        {
            var semesterDeleted = _context.Semesters.FirstOrDefault(c => c.Id == id);
            if (semesterDeleted != null)
            {
                _context.Semesters.Remove(semesterDeleted);
                _context.SaveChanges();
            }
            return semesterDeleted;
        }

        public List<Semester> GetAllSemesters()
        {
            return _context.Semesters.ToList();
        }

        public Semester GetSemester(int id)
        {
            var semester = _context.Semesters.FirstOrDefault(c => c.Id == id);
            return semester;
        }

        public Semester UpdateSemester(int id, Semester semester)
        {
            var semesterUpdate = _context.Semesters.FirstOrDefault(c => c.Id == id);
            if (semesterUpdate != null)
            {
                semesterUpdate.OrdinalNumber = semester.OrdinalNumber;
                semesterUpdate.CardinalNumber = semester.CardinalNumber;
                _context.SaveChanges();
            }
            return semesterUpdate;
        }
    }
}
