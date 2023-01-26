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
        private readonly IScheduledClassRepository _repoSch;
        public SubjectService(ISubjectRepository repo, IScheduledClassRepository repoSch)
        {
            _repo = repo;
            _repoSch = repoSch;
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

        public List<SubjectWithScheduledClassesDto> GetSubjectsWithScheduledClasses()
        {
            var subjectsWithSchClss = new List<SubjectWithScheduledClassesDto>();
            var subjects = _repo.GetAllSubjects();
            foreach (var subject in subjects)
            {
                var subjectWithSchClss = (SubjectWithScheduledClassesDto)subject;
                subjectWithSchClss.ScheduledClasses = _repoSch.GetScheduledClassesOf(subject.Id);
                subjectsWithSchClss.Add(subjectWithSchClss);
            }
            return subjectsWithSchClss;
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
