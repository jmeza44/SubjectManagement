using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface ISemesterService
    {
        Semester AddSemester(SemesterDto semesterDto);
        Semester DeleteSemester(int id);
        List<Semester> GetAllSemesters();
        Semester GetSemester(int id);
        Semester UpdateSemester(int id, SemesterDto semesterDto);
    }
}
