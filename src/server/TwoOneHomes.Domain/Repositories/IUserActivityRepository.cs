using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Repositories;

public interface IUserActivityRepository
{
    void AddUserActivity(UserActivity userActivity);
}