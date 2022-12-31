using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class ScheduledClassWithSubjectAndClassroomDto
    {
        public DateTime StartTime { get; set; }
        public double Duration { get; set; }
        public ClassroomDto ClassroomDto { get; set; }
        public SubjectDto SubjectDto { get; set; }

        public static explicit operator ScheduledClassWithSubjectAndClassroomDto(ScheduledClass scheduledClass)
        {
            return new ScheduledClassWithSubjectAndClassroomDto()
            {
                StartTime = scheduledClass.StartTime,
                Duration = scheduledClass.Duration,
                ClassroomDto = (ClassroomDto)scheduledClass.Classroom,
                SubjectDto = (SubjectDto)scheduledClass.Subject
            };
        }
    }
}
