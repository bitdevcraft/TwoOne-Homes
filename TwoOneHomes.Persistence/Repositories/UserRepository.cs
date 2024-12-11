using System.Collections.ObjectModel;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Users;
using Microsoft.EntityFrameworkCore;
using TwoOneHomes.Domain.Repositories.Identities;

namespace TwoOneHomes.Persistence.Repositories;

public class UserRepository(ApplicationDbContext dbContext) : IUserRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<List<User>> GetUsers() => await _dbContext.Set<User>()
        .AsNoTracking()
        .Include(x => x.UserRoles)
        .ThenInclude(x => x.Role)
        .ToListAsync();
}