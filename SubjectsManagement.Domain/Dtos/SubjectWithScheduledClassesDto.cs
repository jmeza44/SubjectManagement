using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class SubjectWithScheduledClassesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SemesterId { get; set; }
        public SemesterDto Semester { get; set; }
        public int TeacherId { get; set; }
        public TeacherDto Teacher { get; set; }
        public List<ScheduledClass> ScheduledClasses { get; set; }

        public static explicit operator SubjectWithScheduledClassesDto(Subject subject)
        {
            return new SubjectWithScheduledClassesDto
            {
                Id = subject.Id,
                Name = subject.Name,
                SemesterId = subject.SemesterId,
                Semester = (SemesterDto)subject.Semester,
                TeacherId = subject.TeacherId,
                Teacher = (TeacherDto)subject.Teacher,
                ScheduledClasses = new List<ScheduledClass>()
            };
        }

        public static explicit operator Subject(SubjectWithScheduledClassesDto subjectWithScheduledClassesDto)
        {
            return new Subject
            {
                Id = subjectWithScheduledClassesDto.Id,
                Name = subjectWithScheduledClassesDto.Name,
                SemesterId = subjectWithScheduledClassesDto.SemesterId,
                Semester = (Semester)subjectWithScheduledClassesDto.Semester,
                TeacherId = subjectWithScheduledClassesDto.TeacherId,
                Teacher = (Teacher)subjectWithScheduledClassesDto.Teacher,
            };
        }
    }
}
