using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class ScheduledClassService : IScheduledClassService
    {
        private readonly IScheduledClassRepository _repo;

        public ScheduledClassService(IScheduledClassRepository repo)
        {
            _repo = repo;
        }

        public OperationResult<ScheduledClass?> AddScheduledClass(ScheduledClassDto scheduledClassDto)
        {
            var scheduledClass = _repo.AddScheduledClass((ScheduledClass)scheduledClassDto);
            return new AddOperationResult<ScheduledClass?>(scheduledClass, "ScheduledClass");
        }

        public OperationResult<ScheduledClass?> DeleteScheduledClass(int id)
        {
            var scheduledClass = _repo.DeleteScheduledClass(id);
            return new DeleteOperationResult<ScheduledClass?>(scheduledClass, "ScheduledClass", id);
        }

        public OperationResult<List<ScheduledClassDto>> GetAllScheduledClassess()
        {
            var scheduledClasses = _repo.GetAllScheduledClassess();
            var scheduledClassesDto = scheduledClasses.Select(s => (ScheduledClassDto)s).ToList();
            return new GetAllOperationResult<List<ScheduledClassDto>>(scheduledClassesDto, "ScheduledClass", scheduledClassesDto.Count);
        }

        public OperationResult<ScheduledClass?> GetScheduledClass(int id)
        {
            var scheduledClass = _repo.GetScheduledClass(id);
            return new GetOperationResult<ScheduledClass?>(scheduledClass, "ScheduledClass", id);
        }

        public OperationResult<ScheduledClass?> UpdateScheduledClass(int id, ScheduledClassDto scheduledClassDto)
        {
            var scheduledClass = _repo.UpdateScheduledClass(id, (ScheduledClass)scheduledClassDto);
            return new UpdateOperationResult<ScheduledClass?>(scheduledClass, "ScheduledClass", id);
        }
    }
}
