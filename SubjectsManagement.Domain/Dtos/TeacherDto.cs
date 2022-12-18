using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class TeacherDto
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public static explicit operator Teacher(TeacherDto teacher)
        {
            return new Teacher
            {
                Name = teacher.Name,
                PhoneNumber = teacher.PhoneNumber,
                Email = teacher.Email,
            };
        }

        public static explicit operator TeacherDto(Teacher teacher)
        {
            return new TeacherDto
            {
                Name = teacher.Name,
                PhoneNumber = teacher.PhoneNumber,
                Email = teacher.Email,
            };
        }
    }
}
