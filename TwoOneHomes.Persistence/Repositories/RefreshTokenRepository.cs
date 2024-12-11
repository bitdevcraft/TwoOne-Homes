using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Users;
using Microsoft.EntityFrameworkCore;
using TwoOneHomes.Domain.Repositories.Identities;
using TwoOneHomes.Domain.Users.Tokens;

namespace TwoOneHomes.Persistence.Repositories;

public class RefreshTokenRepository(ApplicationDbContext dbContext) : IRefreshTokenRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<RefreshToken?> GetRefreshToken(string refreshToken)
        => await _dbContext.Set<RefreshToken>()
            .Where(rt => rt.Token == refreshToken
                         && rt.IsUsed == false)
            .Include(u => u.User)
            .FirstOrDefaultAsync();
}