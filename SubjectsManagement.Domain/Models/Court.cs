namespace SubjectsManagement.Domain.Models
{
    public class Court
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
