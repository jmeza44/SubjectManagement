namespace SubjectsManagement.Domain.Models
{
    public class ScheduledClass
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public double Duration { get; set; }
        public Classroom Classroom { get; set; }
        public Subject Subject { get; set; }
    }
}
