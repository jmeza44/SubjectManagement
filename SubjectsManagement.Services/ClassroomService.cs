using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Abstractions.Services;
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

        public Classroom AddClassroom(ClassroomDto classroomDto)
        {
            var classroom = _repo.AddClassroom((Classroom)classroomDto);
            return classroom;
        }

        public Classroom DeleteClassroom(int id)
        {
            var classroom = _repo.DeleteClassroom(id);
            return classroom;
        }

        public List<Classroom> GetAllClassrooms()
        {
            var scheduledClasses = _repo.GetAllClassrooms();
            return scheduledClasses;
        }

        public Classroom GetClassroom(int id)
        {
            var classroom = _repo.GetClassroom(id);
            return classroom;
        }

        public Classroom UpdateClassroom(int id, ClassroomDto classroomDto)
        {
            var classroom = _repo.UpdateClassroom(id, (Classroom)classroomDto);
            return classroom;
        }
    }
}
