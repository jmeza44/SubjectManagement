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
            _context.SaveChanges();
            return _subject.Entity;
        }

        public Subject DeleteSubject(int id)
        {
            var _subject = _context.Subjects.Include(s => s.Teacher)
                .Include(s => s.Semester)
                .FirstOrDefault(s => s.Id == id);
            if (_subject != null)
            {
                var _scheduledClasses = _context.ScheduledClasses.Where(s => s.Subject.Id == id).ToArray();
                _context.ScheduledClasses.RemoveRange(_scheduledClasses);
                _context.Subjects.Remove(_subject);
                _context.SaveChanges();
            }
            return _subject;
        }

        public List<Subject> GetAllSubjects()
        {
            var _subjects = _context.Subjects.Include(s => s.Semester)
                .Include(s => s.Teacher)
                .ToList();
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
            var _subject = _context.Subjects.Include(s => s.Teacher)
                .Include(s => s.Semester)
                .FirstOrDefault(s => s.Id == id);
            if (_subject != null)
            {
                _subject.Name = subject.Name;
                _subject.Semester.CardinalNumber = subject.Semester.CardinalNumber;
                _subject.Semester.OrdinalNumber = subject.Semester.OrdinalNumber;
                _subject.Teacher.Name = subject.Teacher.Name;
                _subject.Teacher.PhoneNumber = subject.Teacher.PhoneNumber;
                _subject.Teacher.Email = subject.Teacher.Email;
                _context.SaveChanges();
            }
            return _subject;
        }
    }
}
