using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Persistence.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly AppDbContext _context;
        public ActivityRepository(AppDbContext context)
        {
            _context = context;
        }

        public Activity AddActivity(Activity activity)
        {
            var activityAdded = _context.Add(activity);
            _context.SaveChanges();
            return activityAdded.Entity;
        }

        public Activity DeleteActivity(int id)
        {
            var activityDeleted = _context.Activities.FirstOrDefault(c => c.Id == id);
            if (activityDeleted != null)
            {
                _context.Activities.Remove(activityDeleted);
                _context.SaveChanges();
            }
            return activityDeleted;
        }

        public List<Activity> GetAllActivities()
        {
            return _context.Activities.ToList();
        }

        public Activity GetActivity(int id)
        {
            var activity = _context.Activities.FirstOrDefault(c => c.Id == id);
            return activity;
        }

        public Activity UpdateActivity(int id, Activity activity)
        {
            var activityUpdated = _context.Activities.FirstOrDefault(c => c.Id == id);
            if (activityUpdated != null)
            {
                activityUpdated.Status = activity.Status;
                activityUpdated.Deadline = activity.Deadline;
                activityUpdated.IsIndividual = activity.IsIndividual;
                activityUpdated.Type = activity.Type;
                activityUpdated.Description = activity.Description;
                _context.SaveChanges();
            }
            return activityUpdated;
        }
    }
}
