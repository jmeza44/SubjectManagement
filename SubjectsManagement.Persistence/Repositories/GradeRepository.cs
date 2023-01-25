using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly AppDbContext _context;
        public GradeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Grade AddGrade(Grade grade)
        {
            var gradeAdded = _context.Add(grade);
            _context.SaveChanges();
            return gradeAdded.Entity;
        }

        public Grade DeleteGrade(int id)
        {
            var gradeDeleted = _context.Grades.FirstOrDefault(c => c.Id == id);
            if (gradeDeleted != null)
            {
                _context.Grades.Remove(gradeDeleted);
                _context.SaveChanges();
            }
            return gradeDeleted;
        }

        public List<Grade> GetAllGrades()
        {
            return _context.Grades.ToList();
        }

        public Grade GetGrade(int id)
        {
            var grade = _context.Grades.FirstOrDefault(c => c.Id == id);
            return grade;
        }

        public Grade UpdateGrade(int id, Grade grade)
        {
            var gradeUpdated = _context.Grades.FirstOrDefault(c => c.Id == id);
            if (gradeUpdated != null)
            {
                gradeUpdated.Value = grade.Value;
                gradeUpdated.Weight = grade.Weight;
                _context.SaveChanges();
            }
            return gradeUpdated;
        }
    }
}
