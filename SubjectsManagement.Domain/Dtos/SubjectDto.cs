using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class SubjectDto
    {
        public string Name { get; set; }
        public int SemesterId { get; set; }
        public int TeacherId { get; set; }

        public static explicit operator SubjectDto(Subject subject)
        {
            return new SubjectDto
            {
                Name = subject.Name,
                SemesterId = subject.SemesterId,
                TeacherId = subject.TeacherId
            };
        }

        public static explicit operator Subject(SubjectDto subjectDto)
        {
            return new Subject
            {
                Name = subjectDto.Name,
                SemesterId = subjectDto.SemesterId,
                TeacherId = subjectDto.TeacherId
            };
        }
    }
}
