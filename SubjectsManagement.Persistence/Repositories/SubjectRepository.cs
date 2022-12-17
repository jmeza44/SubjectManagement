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
            var addedSubject = _context.Subjects.Add(subject);
            return addedSubject.Entity;
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
            throw new NotImplementedException();
        }

        public Subject UpdateSubject(int id, Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
