using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Common;
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

        public OperationResult<Semester> AddSemester(SemesterDto semesterDto)
        {
            var semesterAdded = _repo.AddSemester((Semester)semesterDto);
            return new AddOperationResult<Semester>(semesterAdded, "Semester");
        }

        public OperationResult<Semester> DeleteSemester(int id)
        {
            var semesterDeleted = _repo.DeleteSemester(id);
            return new DeleteOperationResult<Semester>(semesterDeleted, "Semester", id);
        }

        public OperationResult<List<Semester>> GetAllSemesters()
        {
            var semesters = _repo.GetAllSemesters();
            return new GetAllOperationResult<List<Semester>>(semesters, "Semester", semesters.Count);
        }

        public OperationResult<Semester> GetSemester(int id)
        {
            var semester = _repo.GetSemester(id);
            return new GetOperationResult<Semester>(semester, "Semester", id);
        }

        public OperationResult<Semester> UpdateSemester(int id, SemesterDto semesterDto)
        {
            var semester = _repo.UpdateSemester(id, (Semester)semesterDto);
            return new UpdateOperationResult<Semester>(semester, "Semester", id);

        }
    }
}
