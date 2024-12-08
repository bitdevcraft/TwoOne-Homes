using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetUsers();
}