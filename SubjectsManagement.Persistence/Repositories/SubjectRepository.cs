using Microsoft.EntityFrameworkCore;
using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly AppDbContext _context;
        public SubjectRepository(AppDbContext context)
        {
            _context = context;
        }
        public Subject AddSubject(Subject subject)
        {
            var _subject = _context.Subjects.Add(subject);
            return _subject.Entity;
        }

        public Subject DeleteSubject(int id)
        {
            throw new NotImplementedException();
        }

        public List<Subject> GetAllSubjects()
        {
            var _subjects = _context.Subjects.ToList();
            return _subjects;
        }

        public Subject GetSubject(int id)
        {
            var _subject = _context.Subjects.Include(s => s.Teacher)
                .Include(s => s.Semester)
                .FirstOrDefault(s => s.Id == id);
            return _subject;
        }

        public Subject UpdateSubject(int id, Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
