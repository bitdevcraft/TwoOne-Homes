using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Users;
using TwoOneHomes.Domain.Users.Activities;

namespace TwoOneHomes.Persistence.Repositories;

public class UserActivityRepository(ApplicationDbContext dbContext) : IUserActivityRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public void AddUserActivity(UserActivity userActivity) =>
        _dbContext.Set<UserActivity>().Add(userActivity);
}