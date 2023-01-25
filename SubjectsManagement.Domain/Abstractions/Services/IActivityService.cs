using SubjectsManagement.Domain.Dtos;
using SubjectsManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectsManagement.Domain.Abstractions.Services
{
    public interface IActivityService
    {
        Activity AddActivity(ActivityDto activityDto);
        Activity DeleteActivity(int id);
        List<Activity> GetAllActivities();
        Activity GetActivity(int id);
        Activity UpdateActivity(int id, ActivityDto activityDto);
    }
}
