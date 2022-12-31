﻿using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions
{
    public interface IScheduledClassService
    {
        OperationResult<ScheduledClass> AddScheduledClass(ScheduledClassDto scheduledClass);
        OperationResult<ScheduledClass> AddScheduledClassWithClassroom(ScheduledClassWithClassroomDto scheduledClass);
        OperationResult<ScheduledClass> DeleteScheduledClass(int id);
        OperationResult<List<ScheduledClassDto>> GetAllScheduledClassess();
        OperationResult<ScheduledClass> GetScheduledClass(int id);
        OperationResult<ScheduledClass> UpdateScheduledClass(int id, ScheduledClassDto scheduledClass);
    }
}