using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface ISubjectService
    {
        Subject AddSubject(SubjectDto subjectDto);
        Subject DeleteSubject(int id);
        List<Subject> GetAllSubjects();
        List<SubjectWithScheduledClassesDto> GetSubjectsWithScheduledClasses();
        Subject GetSubject(int id);
        Subject UpdateSubject(int id, SubjectDto subjectDto);
    }
}
