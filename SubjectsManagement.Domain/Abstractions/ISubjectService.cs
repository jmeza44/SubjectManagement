using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface ISubjectService
    {
        Subject AddSubject(SubjectDto subjectDto);
        Subject DeleteSubject(int id);
        List<Subject> GetAllSubjects();
        Subject GetSubject(int id);
        Subject UpdateSubject(int id, SubjectDto subjectDto);
    }
}
