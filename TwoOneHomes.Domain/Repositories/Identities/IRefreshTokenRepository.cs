using TwoOneHomes.Domain.Users.Tokens;

namespace TwoOneHomes.Domain.Repositories.Identities;

public interface IRefreshTokenRepository
{
    Task<RefreshToken?> GetRefreshToken(string refreshToken);
}