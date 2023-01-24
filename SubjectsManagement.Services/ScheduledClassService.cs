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
            var _scheduledClass = _repo.AddScheduledClass((ScheduledClass)scheduledClassDto);
            return new OperationResult<ScheduledClass?>()
            {
                Message = "Success",
                Description = "ScheduledClass added propertly",
                Result = _scheduledClass
            };
        }

        public OperationResult<ScheduledClass?> DeleteScheduledClass(int id)
        {
            var _scheduledClass = _repo.DeleteScheduledClass(id);
            if (_scheduledClass != null)
            {
                return new OperationResult<ScheduledClass?>()
                {
                    Message = "Success",
                    Description = "ScheduledClass deleted propertly",
                    Result = _scheduledClass
                };
            }
            return new OperationResult<ScheduledClass?>()
            {
                Message = "Error",
                Description = $"ScheduledClass with id {id} found",
                Result = null
            };
        }

        public OperationResult<List<ScheduledClassDto>> GetAllScheduledClassess()
        {
            var _scheduledClasses = _repo.GetAllScheduledClassess();
            var _scheduledClassesDto = _scheduledClasses.Select(s => (ScheduledClassDto)s).ToList();
            return new OperationResult<List<ScheduledClassDto>>()
            {
                Message = "Success",
                Description = $"{_scheduledClassesDto.Count} ScheduledClass(ess) retrieved propertly",
                Result = _scheduledClassesDto
            };
        }

        public OperationResult<ScheduledClass?> GetScheduledClass(int id)
        {
            var _scheduledClass = _repo.GetScheduledClass(id);
            if (_scheduledClass != null)
            {
                return new OperationResult<ScheduledClass?>()
                {
                    Message = "Success",
                    Description = $"ScheduledClass with id {id} found",
                    Result = _scheduledClass
                };
            }
            return new OperationResult<ScheduledClass?>()
            {
                Message = "Error",
                Description = $"ScheduledClass with id {id} couldn't be found",
                Result = null
            };
        }

        public OperationResult<ScheduledClass?> UpdateScheduledClass(int id, ScheduledClassDto scheduledClassDto)
        {
            var _scheduledClass = _repo.UpdateScheduledClass(id, (ScheduledClass)scheduledClassDto);
            if (_scheduledClass != null)
            {
                return new OperationResult<ScheduledClass?>()
                {
                    Message = "Success",
                    Description = "ScheduledClass updated propertly",
                    Result = _scheduledClass
                };
            }
            return new OperationResult<ScheduledClass?>()
            {
                Message = "Error",
                Description = $"ScheduledClass with id {id} couldn't be found",
                Result = null
            };
        }
    }
}
