using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface IClassroomService
    {
        Classroom AddClassroom(ClassroomDto classroomDto);
        Classroom DeleteClassroom(int id);
        List<Classroom> GetAllClassrooms();
        Classroom GetClassroom(int id);
        Classroom UpdateClassroom(int id, ClassroomDto classroomDto);
    }
}
