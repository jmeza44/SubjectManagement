using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface ISemesterService
    {
        OperationResult<Semester> AddSemester(SemesterDto semesterDto);
        OperationResult<Semester> DeleteSemester(int id);
        OperationResult<List<Semester>> GetAllSemesters();
        OperationResult<Semester> GetSemester(int id);
        OperationResult<Semester> UpdateSemester(int id, SemesterDto semesterDto);
    }
}
