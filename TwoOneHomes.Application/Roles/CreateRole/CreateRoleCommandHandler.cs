using TwoOneHomes.Application.Abstraction.Messaging;
using Microsoft.AspNetCore.Identity;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Roles;

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
