using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Shared;
using TwoOneHomes.Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TwoOneHomes.Application.Roles.ListRole;

internal sealed class ListRoleQueryHandler(RoleManager<Role> roleManager)
    : IQueryHandler<ListRoleQuery, List<string?>>
{
    private readonly RoleManager<Role> _roleManager = roleManager;

    public async Task<Result<List<string?>>> Handle(
        ListRoleQuery request,
        CancellationToken cancellationToken
    ) => await _roleManager.Roles.Select(x => x.Name).ToListAsync(cancellationToken);
}
