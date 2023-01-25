using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface IGradeService
    {
        Grade AddGrade(GradeDto gradeDto);
        Grade DeleteGrade(int id);
        List<Grade> GetAllGrades();
        Grade GetGrade(int id);
        Grade UpdateGrade(int id, GradeDto gradeDto);
    }
}
