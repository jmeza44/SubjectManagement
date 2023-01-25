using SubjectsManagement.Domain.Abstractions.Repositories;
using SubjectsManagement.Domain.Abstractions.Services;
using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _repo;

        public ActivityService(IActivityRepository repo)
        {
            _repo = repo;
        }

        public Activity AddActivity(ActivityDto activityDto)
        {
            var activity = _repo.AddActivity((Activity)activityDto);
            return activity;
        }

        public Activity DeleteActivity(int id)
        {
            var activity = _repo.DeleteActivity(id);
            return activity;
        }

        public List<Activity> GetAllActivities()
        {
            var activities = _repo.GetAllActivities();
            return activities;
        }

        public Activity GetActivity(int id)
        {
            var activity = _repo.GetActivity(id);
            return activity;
        }

        public Activity UpdateActivity(int id, ActivityDto activityDto)
        {
            var activity = _repo.UpdateActivity(id, (Activity)activityDto);
            return activity;
        }
    }
}
