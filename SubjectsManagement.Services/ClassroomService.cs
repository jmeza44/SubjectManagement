using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class ClassroomService : IClassroomService
    {
        private readonly IClassroomRepository _repo;

        public ClassroomService(IClassroomRepository repo)
        {
            _repo = repo;
        }

        public OperationResult<Classroom?> AddClassroom(ClassroomDto classroomDto)
        {
            var classroom = _repo.AddClassroom((Classroom)classroomDto);
            return new AddOperationResult<Classroom?>(classroom, "Classroom");
        }

        public OperationResult<Classroom?> DeleteClassroom(int id)
        {
            var classroom = _repo.DeleteClassroom(id);
            return new DeleteOperationResult<Classroom?>(classroom, "Classroom", id);
        }

        public OperationResult<List<Classroom>> GetAllClassrooms()
        {
            var classrooms = _repo.GetAllClassrooms();
            return new GetAllOperationResult<List<Classroom>>(classrooms, "Classroom", classrooms.Count);
        }

        public OperationResult<Classroom?> GetClassroom(int id)
        {
            var _classroom = _repo.GetClassroom(id);
                return new GetOperationResult<Classroom?>(_classroom, "Classroom", id);
        }

        public OperationResult<Classroom?> UpdateClassroom(int id, ClassroomDto classroomDto)
        {
            var classroom = _repo.UpdateClassRoom(id, (Classroom)classroomDto);
            return new UpdateOperationResult<Classroom?>(classroom, "Classroom", id);
        }
    }
}
