using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class CourtDto
    {
        public string Name { get; set; }
        public int GradeId { get; set; }
        public int SubjectId { get; set; }

        public static explicit operator Court(CourtDto court)
        {
            return new Court
            {
                Name = court.Name,
                GradeId = court.GradeId,
                SubjectId = court.SubjectId
            };
        }
        public static explicit operator CourtDto(Court court)
        {
            return new CourtDto
            {
                Name = court.Name,
                GradeId = court.GradeId,
                SubjectId = court.SubjectId
            };
        }
    }
}
