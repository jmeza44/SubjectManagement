using Microsoft.EntityFrameworkCore;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<ScheduledClass> ScheduledClasses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}