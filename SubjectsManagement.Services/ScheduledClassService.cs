using SubjectsManagement.Domain.Abstractions;
using SubjectsManagement.Domain.Common;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class ScheduledClassService : IScheduledClassService
    {
        private readonly IScheduledClassRepository _repo;
        private readonly IClassroomRepository _repoClassroom;
        private readonly ISubjectRepository _repoSubject;

        public ScheduledClassService(IScheduledClassRepository repo, IClassroomRepository repoClassroom, ISubjectRepository repoSubject)
        {
            _repo = repo;
            _repoClassroom = repoClassroom;
            _repoSubject = repoSubject;
        }

        public OperationResult<ScheduledClass?> AddScheduledClass(ScheduledClassDto scheduledClass)
        {
            var _classroom = _repoClassroom.GetClassroom(scheduledClass.ClassroomId);
            var _subject = _repoSubject.GetSubject(scheduledClass.SubjectId);
            if (_classroom != null && _subject != null)
            {
                var _scheduledClass = _repo.AddScheduledClass(new ScheduledClass()
                {
                    StartTime = scheduledClass.StartTime,
                    Duration = scheduledClass.Duration,
                    Classroom = _classroom,
                    Subject = _subject
                });
                return new OperationResult<ScheduledClass?>()
                {
                    Message = "Success",
                    Description = "ScheduledClass added propertly",
                    Result = _scheduledClass
                };
            }
            return new OperationResult<ScheduledClass?>()
            {
                Message = "Error",
                Description = "Classroom or Subject cloudn't be found",
                Result = null
            };
        }

        public OperationResult<ScheduledClass?> AddScheduledClassWithClassroom(ScheduledClassWithClassroomDto scheduledClass)
        {
            var _classroom = _repoClassroom.AddClassroom((Classroom)scheduledClass.Classroom);
            var _subject = _repoSubject.GetSubject(scheduledClass.SubjectId);
            if (_subject != null)
            {
                var _scheduledClass = _repo.AddScheduledClass(new ScheduledClass()
                {
                    StartTime = scheduledClass.StartTime,
                    Duration = scheduledClass.Duration,
                    Classroom = _classroom,
                    Subject = _subject,
                });
                return new OperationResult<ScheduledClass?>()
                {
                    Message = "Success",
                    Description = "ScheduledClass added propertly",
                    Result = _scheduledClass
                };
            }
            return new OperationResult<ScheduledClass?>()
            {
                Message = "Error",
                Description = "Subject cloudn't be found",
                Result = null
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

        public OperationResult<ScheduledClass?> UpdateScheduledClass(int id, ScheduledClassDto scheduledClass)
        {
            var _scheduledClass = _repo.UpdateScheduledClass(id, (ScheduledClass)scheduledClass);
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
