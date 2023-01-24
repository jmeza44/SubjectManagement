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
            var _classroom = _repo.AddClassroom((Classroom)classroomDto);
            if (_classroom != null)
            {
                return new OperationResult<Classroom?>()
                {
                    Message = "Success",
                    Description = "Classroom added propertly",
                    Result = _classroom
                };
            }
            return new OperationResult<Classroom?>()
            {
                Message = "Error",
                Description = "Classroom couldn't be added",
                Result = null
            };
        }

        public OperationResult<Classroom?> DeleteClassroom(int id)
        {
            var _classroom = _repo.DeleteClassroom(id);
            if (_classroom != null)
            {
                return new OperationResult<Classroom?>()
                {
                    Message = "Success",
                    Description = "Classroom deleted propertly",
                    Result = _classroom
                };
            }
            return new OperationResult<Classroom?>()
            {
                Message = "Error",
                Description = $"Classroom with id {id} found",
                Result = null
            };
        }

        public OperationResult<List<Classroom>> GetAllClassrooms()
        {
            var _classroom = _repo.GetAllClassrooms();
            return new OperationResult<List<Classroom>>()
            {
                Message = "Success",
                Description = $"{_classroom.Count} Classroom(s) retrieved propertly",
                Result = _classroom
            };
        }

        public OperationResult<Classroom?> GetClassroom(int id)
        {
            var _classroom = _repo.GetClassroom(id);
            if (_classroom != null)
            {
                return new OperationResult<Classroom?>()
                {
                    Message = "Success",
                    Description = $"Classroom with id {id} found",
                    Result = _classroom
                };
            }
            return new OperationResult<Classroom?>()
            {
                Message = "Error",
                Description = $"Classroom with id {id} couldn't be found",
                Result = null
            };
        }

        public OperationResult<Classroom?> UpdateClassroom(int id, ClassroomDto classroomDto)
        {
            var _classroom = _repo.UpdateClassRoom(id, (Classroom)classroomDto);
            if (_classroom != null)
            {
                return new OperationResult<Classroom?>()
                {
                    Message = "Success",
                    Description = "Classroom updated propertly",
                    Result = _repo.UpdateClassRoom(id, (Classroom)classroomDto)
                };
            }
            return new OperationResult<Classroom?>()
            {
                Message = "Error",
                Description = $"Classroom with id {id} couldn't be found",
                Result = null
            };
        }
    }
}
