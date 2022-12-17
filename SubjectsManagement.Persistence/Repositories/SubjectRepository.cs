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
            throw new NotImplementedException();
        }

        public Subject GetSubject(int id)
        {
            var _subject = _context.Subjects.FirstOrDefault(x => x.Id == id);
            return _subject;
        }

        public Subject UpdateSubject(int id, Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
