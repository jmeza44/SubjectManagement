using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class GradeDto
    {
        public double Value { get; set; }
        public double Weight { get; set; }

        public static explicit operator Grade(GradeDto grade)
        {
            return new Grade
            {
                Value = grade.Value,
                Weight = grade.Weight
            };
        }
        public static explicit operator GradeDto(Grade grade)
        {
            return new GradeDto
            {
                Value = grade.Value,
                Weight = grade.Weight
            };
        }
    }
}
