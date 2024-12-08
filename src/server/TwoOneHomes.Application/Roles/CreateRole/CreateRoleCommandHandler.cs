using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Shared;
using TwoOneHomes.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace TwoOneHomes.Application.Roles.CreateRole;

internal sealed class CreateRoleCommandHandler(RoleManager<Role> roleManager)
    : ICommandHandler<CreateRoleCommand>
{
    private readonly RoleManager<Role> _roleManager = roleManager;

    public async Task<Result> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        Role? exist = await _roleManager.FindByNameAsync(request.RoleName);

        if (exist != null)
        {
            return Result.Failure(Error.Validation("Role already Exists"));
        }
        var role = new Role(request.RoleName);
        await _roleManager.CreateAsync(role);

        return Result.Success();
    }
}
