using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Common;
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

        public OperationResult<Subject?> AddSubject(SubjectDto subject)
        {
            var _subject = _repo.AddSubject((Subject)subject); ;
            if (_subject != null)
            {
                return new OperationResult<Subject?>()
                {
                    Message = "Success",
                    Description = "Subject added propertly",
                    Result = _subject
                };
            }
            return new OperationResult<Subject?>()
            {
                Message = "Error",
                Description = "Subject couldn't be added",
                Result = null
            };
        }

        public OperationResult<Subject?> DeleteSubject(int id)
        {
            var _subject = _repo.DeleteSubject(id);
            if (_subject != null)
            {
                return new OperationResult<Subject?>()
                {
                    Message = "Success",
                    Description = "Subject deleted propertly",
                    Result = _subject
                };
            }
            return new OperationResult<Subject?>()
            {
                Message = "Error",
                Description = $"Subject with id {id} found",
                Result = null
            };
        }

        public OperationResult<List<Subject>> GetAllSubjects()
        {
            var _subject = _repo.GetAllSubjects();
            return new OperationResult<List<Subject>>()
            {
                Message = "Success",
                Description = $"{_subject.Count} Subject(s) retrieved propertly",
                Result = _subject
            };
        }

        public OperationResult<Subject?> GetSubject(int id)
        {
            var _subject = _repo.GetSubject(id);
            if (_subject != null)
            {
                return new OperationResult<Subject?>()
                {
                    Message = "Success",
                    Description = $"Subject with id {id} found",
                    Result = _subject
                };
            }
            return new OperationResult<Subject?>()
            {
                Message = "Error",
                Description = $"Subject with id {id} couldn't be found",
                Result = null
            };
        }

        public OperationResult<Subject?> UpdateSubject(int id, SubjectDto subject)
        {
            var _subject = _repo.UpdateSubject(id, (Subject)subject);
            if (_subject != null)
            {
                return new OperationResult<Subject?>()
                {
                    Message = "Success",
                    Description = "Subject updated propertly",
                    Result = _subject
                };
            }
            return new OperationResult<Subject?>()
            {
                Message = "Error",
                Description = $"Subject with id {id} couldn't be found",
                Result = null
            };
        }
    }
}
