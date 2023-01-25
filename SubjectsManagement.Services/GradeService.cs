using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _repo;

        public GradeService(IGradeRepository repo)
        {
            _repo = repo;
        }

        public Grade AddGrade(GradeDto gradeDto)
        {
            var grade = _repo.AddGrade((Grade)gradeDto);
            return grade;
        }

        public Grade DeleteGrade(int id)
        {
            var grade = _repo.DeleteGrade(id);
            return grade;
        }

        public List<Grade> GetAllGrades()
        {
            var grades = _repo.GetAllGrades();
            return grades;
        }

        public Grade GetGrade(int id)
        {
            var grade = _repo.GetGrade(id);
            return grade;
        }

        public Grade UpdateGrade(int id, GradeDto gradeDto)
        {
            var grade = _repo.UpdateGrade(id, (Grade)gradeDto);
            return grade;
        }
    }
}
