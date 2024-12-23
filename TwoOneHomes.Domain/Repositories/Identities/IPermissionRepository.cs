﻿using TwoOneHomes.Domain.Users.Permissions;

namespace TwoOneHomes.Domain.Repositories.Identities;

public interface IPermissionRepository
{
    Task<Permission?> FindByNameAsync(string name);
    Task<int> CreateAsync(string name);
    Task<int> DeleteAsync(Permission permission);
    Task<List<string>> GetAllByRoleIdAsync(string Id);
    Task<HashSet<string>> GetAllByUserIdAsync(string Id);
    Task<List<string>> GetAllAsync();
    Task<int> AddRangeAsync(ICollection<string> names);
}
