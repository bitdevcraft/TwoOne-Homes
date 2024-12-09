using TwoOneHomes.Application.Abstraction.Messaging;
using Microsoft.AspNetCore.Identity;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Roles;

namespace TwoOneHomes.Application.Roles.DeleteRole;

internal sealed class DeleteRoleCommandHandler(RoleManager<Role> roleManager)
    : ICommandHandler<DeleteRoleCommand>
{
    private readonly RoleManager<Role> _roleManager = roleManager;

    public async Task<Result> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        Role? role = await _roleManager.FindByNameAsync(request.Name);

        if (role is null)
        {
            return Result.Failure(Error.NotFound());
        }

        _ = await _roleManager.DeleteAsync(role);

        return Result.Success();
    }
}
