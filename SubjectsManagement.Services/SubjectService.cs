using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _repo;
        public SubjectService(ISubjectRepository repo)
        {
            _repo = repo;
        }

        public Subject AddSubject(SubjectDto subject)
        {
            return _repo.AddSubject((Subject)subject);
        }

        public Subject DeleteSubject(int id)
        {
            return _repo.DeleteSubject(id);
        }

        public List<Subject> GetAllSubjects()
        {
            return _repo.GetAllSubjects();
        }

        public Subject GetSubject(int id)
        {
            return _repo.GetSubject(id);
        }

        public Subject UpdateSubject(int id, SubjectDto subject)
        {
            return _repo.UpdateSubject(id, (Subject)subject);
        }
    }
}
