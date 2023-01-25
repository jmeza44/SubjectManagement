using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Dtos
{
    public class ActivityDto
    {
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsIndividual { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int GradeId { get; set; }
        public int CourtId { get; set; }

        public static explicit operator Activity(ActivityDto activity)
        {
            return new Activity
            {
                Status = activity.Status,
                Deadline= activity.Deadline,
                IsIndividual = activity.IsIndividual,
                Type = activity.Type,
                Description = activity.Description,
                GradeId = activity.GradeId,
                CourtId = activity.CourtId
            };
        }
        public static explicit operator ActivityDto(Activity activity)
        {
            return new ActivityDto
            {
                Status = activity.Status,
                Deadline = activity.Deadline,
                IsIndividual = activity.IsIndividual,
                Type = activity.Type,
                Description = activity.Description,
                GradeId = activity.GradeId,
                CourtId = activity.CourtId
            };
        }
    }
}
