using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface ISubjectService
    {
        Subject AddSubject(SubjectDto subject);
        Subject DeleteSubject(int id);
        List<Subject> GetAllSubjects();
        Subject GetSubject(int id);
        Subject UpdateSubject(int id, SubjectDto subject);
    }
}
