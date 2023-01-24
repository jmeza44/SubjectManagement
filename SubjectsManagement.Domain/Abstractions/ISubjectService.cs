using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface ISubjectService
    {
        OperationResult<Subject> AddSubject(SubjectDto subjectDto);
        OperationResult<Subject> DeleteSubject(int id);
        OperationResult<List<Subject>> GetAllSubjects();
        OperationResult<Subject> GetSubject(int id);
        OperationResult<Subject> UpdateSubject(int id, SubjectDto subjectDto);
    }
}
