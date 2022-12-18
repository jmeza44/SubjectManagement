using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class SemesterDto
    {
        public string OrdinalNumber { get; set; }
        public int CardinalNumber { get; set; }

        public static explicit operator Semester(SemesterDto semester)
        {
            return new Semester
            {
                OrdinalNumber = semester.OrdinalNumber,
                CardinalNumber = semester.CardinalNumber
            };
        }

        public static explicit operator SemesterDto(Semester semester)
        {
            return new SemesterDto
            {
                OrdinalNumber = semester.OrdinalNumber,
                CardinalNumber = semester.CardinalNumber
            };
        }
    }
}
