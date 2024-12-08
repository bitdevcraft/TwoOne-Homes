using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Repositories;

public interface IRefreshTokenRepository
{
    Task<RefreshToken?> GetRefreshToken(string refreshToken);
}