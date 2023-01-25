using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;
using System.Globalization;

namespace SubjectsManagement.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _repo;
        public SubjectService(ISubjectRepository repo)
        {
            _repo = repo;
        }

        public Subject AddSubject(SubjectDto subjectDto)
        {
            var subject = _repo.AddSubject((Subject)subjectDto);
            return subject;
        }

        public Subject DeleteSubject(int id)
        {
            var subject = _repo.DeleteSubject(id);
            return subject;
        }

        public List<Subject> GetAllSubjects()
        {
            var subjects = _repo.GetAllSubjects();
            return subjects;
        }

        public Subject GetSubject(int id)
        {
            var subject = _repo.GetSubject(id);
            return subject;
        }

        public Subject UpdateSubject(int id, SubjectDto subjectDto)
        {
            var subject = _repo.UpdateSubject(id, (Subject)subjectDto);
            return subject;
        }
    }
}
