using Microsoft.EntityFrameworkCore;
using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class ScheduledClassRepository : IScheduledClassRepository
    {
        private readonly AppDbContext _context;

        public ScheduledClassRepository(AppDbContext context)
        {
            _context = context;
        }

        public ScheduledClass AddScheduledClass(ScheduledClass scheduledClass)
        {
            var _scheduledClass = _context.ScheduledClasses.Add(scheduledClass);
            _context.SaveChanges();
            return _scheduledClass.Entity;
        }

        public ScheduledClass DeleteScheduledClass(int id)
        {
            var _scheduledClass = _context.ScheduledClasses.FirstOrDefault(s => s.Id == id);
            if (_scheduledClass != null)
            {
                _context.Remove(_scheduledClass);
                _context.SaveChanges();
            }
            return _scheduledClass;
        }

        public List<ScheduledClass> GetAllScheduledClasses()
        {
            return _context.ScheduledClasses.Include(s => s.Classroom)
                .Include(s => s.Subject)
                .ToList();
        }

        public ScheduledClass GetScheduledClass(int id)
        {
            var _scheduledClass = _context.ScheduledClasses.FirstOrDefault(s => s.Id == id);
            return _scheduledClass;
        }

        public List<ScheduledClass> GetScheduledClassesOf(int subjectId)
        {
            var scheduledClasses = _context.ScheduledClasses.Where(sc => sc.SubjectId == subjectId).ToList();
            return scheduledClasses;
        }

        public Classroom GetRelatedClassroom(int scheduledClassId)
        {
            var classroom = _context.ScheduledClasses.Where(sch => sch.Id == scheduledClassId)
                .Select(sch => sch.Classroom).FirstOrDefault();
            return classroom;
        }

        public ScheduledClass UpdateScheduledClass(int id, ScheduledClass scheduledClass)
        {
            var _scheduledClass = _context.ScheduledClasses.FirstOrDefault(s => s.Id == id);
            if (_scheduledClass != null)
            {
                _scheduledClass.StartTime = scheduledClass.StartTime;
                _scheduledClass.Duration= scheduledClass.Duration;
                _context.SaveChanges();
            }
            return _scheduledClass;
        }
    }
}
