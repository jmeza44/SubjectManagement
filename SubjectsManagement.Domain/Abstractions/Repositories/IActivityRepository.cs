using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;

namespace SubjectsManagement.Domain.Abstractions.Repositories
{
    public interface IActivityRepository
    {
        Activity AddActivity(Activity activity);
        Activity DeleteActivity(int id);
        List<Activity> GetAllActivities();
        Activity GetActivity(int id);
        Activity UpdateActivity(int id, Activity activity);
    }
}
