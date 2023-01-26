using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class ScheduledClassDto
    {
        public DateTime StartTime { get; set; }
        public double Duration { get; set; }
        public int ClassroomId { get; set; }
        public ClassroomDto ClassroomDto { get; set; }
        public int SubjectId { get; set; }

        public static explicit operator ScheduledClass(ScheduledClassDto scheduleClassDto)
        {
            return new ScheduledClass
            {
                StartTime = scheduleClassDto.StartTime,
                Duration = scheduleClassDto.Duration,
                ClassroomId = scheduleClassDto.ClassroomId,
                Classroom = (Classroom)scheduleClassDto.ClassroomDto,
                SubjectId = scheduleClassDto.SubjectId,
            };
        }
        public static explicit operator ScheduledClassDto(ScheduledClass scheduledClass)
        {
            return new ScheduledClassDto
            {
                StartTime = scheduledClass.StartTime,
                Duration = scheduledClass.Duration,
                ClassroomId = scheduledClass.ClassroomId,
                ClassroomDto = (ClassroomDto)scheduledClass.Classroom,
                SubjectId = scheduledClass.SubjectId,
            };
        }
    }
}
