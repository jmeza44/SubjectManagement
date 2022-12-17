namespace SubjectsManagement.Domain.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsIndividual { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Grade Grade { get; set; }
    }
}
