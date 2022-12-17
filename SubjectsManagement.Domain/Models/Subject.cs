namespace SubjectsManagement.Domain.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Semester Semester { get; set; }
        public Teacher Teacher { get; set; }
    }
}