using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface ISemesterRepository
    {
        Semester AddSemester(Semester semester);
        Semester DeleteSemester(int id);
        List<Semester> GetAllSemesters();
        Semester GetSemester(int id);
        Semester UpdateSemester(int id, Semester semester);
    }
}
