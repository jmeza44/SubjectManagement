using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface IClassroomRepository
    {
        Classroom AddClassroom(Classroom classroom);
        Classroom DeleteClassroom(int id);
        List<Classroom> GetAllClassrooms();
        Classroom GetClassroom(int id);
        Classroom UpdateClassroom(int id, Classroom classroom);
    }
}
