using TwoOneHomes.Application.Abstraction.Messaging;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Roles;

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
