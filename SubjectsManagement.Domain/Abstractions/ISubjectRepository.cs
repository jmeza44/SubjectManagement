using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface ISubjectRepository
    {
        Subject AddSubject(Subject subject);
        Subject DeleteSubject(int id);
        List<Subject> GetAllSubjects();
        Subject GetSubject(int id);
        Subject UpdateSubject(int id, Subject subject);
    }
}
