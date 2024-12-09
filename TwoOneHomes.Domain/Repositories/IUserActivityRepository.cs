using TwoOneHomes.Domain.Users.Activities;

namespace TwoOneHomes.Domain.Repositories;

public interface IUserActivityRepository
{
    void AddUserActivity(UserActivity userActivity);
}