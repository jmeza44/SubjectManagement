using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class SemesterService : ISemesterService
    {
        private readonly ISemesterRepository _repo;
        public SemesterService(ISemesterRepository repo)
        {
            _repo = repo;
        }

        public Semester AddSemester(SemesterDto semesterDto)
        {
            var semester = _repo.AddSemester((Semester)semesterDto);
            return semester;
        }

        public Semester DeleteSemester(int id)
        {
            var semester = _repo.DeleteSemester(id);
            return semester;
        }

        public List<Semester> GetAllSemesters()
        {
            var semester = _repo.GetAllSemesters();
            return semester;
        }

        public Semester GetSemester(int id)
        {
            var semester = _repo.GetSemester(id);
            return semester;
        }

        public Semester UpdateSemester(int id, SemesterDto semesterDto)
        {
            var semester = _repo.UpdateSemester(id, (Semester)semesterDto);
            return semester;
        }
    }
}
