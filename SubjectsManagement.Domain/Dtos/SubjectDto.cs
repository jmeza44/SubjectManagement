using SubjectsManagement.Domain.Models;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace SubjectsManagement.Domain.Dtos
{
    public class SubjectDto
    {
        public string Name { get; set; }
        public SemesterDto Semester { get; set; }
        public TeacherDto Teacher { get; set; }

        public static explicit operator SubjectDto(Subject subject)
        {
            return new SubjectDto
            {
                Name = subject.Name,
                Semester = (SemesterDto)subject.Semester,
                Teacher = (TeacherDto)subject.Teacher
            };
        }

        public static explicit operator Subject(SubjectDto subject)
        {
            return new Subject
            {
                Name = subject.Name,
                Semester = (Semester)subject.Semester,
                Teacher = (Teacher)subject.Teacher
            };
        }
    }
}
