﻿using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface IClassroomRepository
    {
        Classroom AddClassroom(Classroom classroom);
        Classroom DeleteClassroom(int id);
        List<Classroom> GetAllClassrooms();
        Classroom GetClassroom(int id);
        Classroom UpdateClassRoom(int id, Classroom classroom);
    }
}
