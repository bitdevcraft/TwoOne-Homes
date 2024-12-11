using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Repositories.Identities;

public interface IUserRepository
{
    Task<List<User>> GetUsers();
}