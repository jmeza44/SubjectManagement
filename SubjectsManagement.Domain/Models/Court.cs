namespace SubjectsManagement.Domain.Models
{
    public class Court
    {
        public int Id { get; set; }
        public Grade Grade { get; set; }
        public Subject Subject { get; set; }
    }
}
