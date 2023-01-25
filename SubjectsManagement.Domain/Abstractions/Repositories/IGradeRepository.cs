using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface IGradeRepository
    {
        Grade AddGrade(Grade grade);
        Grade DeleteGrade(int id);
        List<Grade> GetAllGrades();
        Grade GetGrade(int id);
        Grade UpdateGrade(int id, Grade grade);
    }
}
