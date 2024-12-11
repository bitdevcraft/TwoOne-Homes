using TwoOneHomes.Domain.Users.Activities;

namespace TwoOneHomes.Domain.Repositories.Identities;

public interface IUserActivityRepository
{
    void AddUserActivity(UserActivity userActivity);
}