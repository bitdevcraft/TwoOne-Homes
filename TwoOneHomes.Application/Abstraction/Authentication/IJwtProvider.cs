using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Application.Abstraction.Authentication;

public interface IJwtProvider
{
    string Generate(User user, IList<string> roles);
}