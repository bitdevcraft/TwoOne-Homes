using TwoOneHomes.Domain.Users.Tokens;

namespace TwoOneHomes.Domain.Repositories;

public interface IRefreshTokenRepository
{
    Task<RefreshToken?> GetRefreshToken(string refreshToken);
}