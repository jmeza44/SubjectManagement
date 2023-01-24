using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class ScheduledClassWithClassroomDto
    {
        public DateTime StartTime { get; set; }
        public double Duration { get; set; }
        public ClassroomDto Classroom { get; set; }
        public int SubjectId { get; set; }

        public static explicit operator ScheduledClassWithClassroomDto(ScheduledClass scheduledClass)
        {
            return new ScheduledClassWithClassroomDto()
            {
                StartTime = scheduledClass.StartTime,
                Duration = scheduledClass.Duration,
                Classroom = (ClassroomDto)scheduledClass.Classroom,
                SubjectId = scheduledClass.Subject.Id
            };
        }
    }
}
