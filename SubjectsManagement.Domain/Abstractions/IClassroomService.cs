using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface IClassroomService
    {
        OperationResult<Classroom> AddClassroom(ClassroomDto classroom);
        OperationResult<Classroom> DeleteClassroom(int id);
        OperationResult<List<Classroom>> GetAllClassrooms();
        OperationResult<Classroom> GetClassroom(int id);
        OperationResult<Classroom> UpdateClassroom(int id, ClassroomDto classroom);
    }
}
