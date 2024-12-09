using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Roles;

namespace TwoOneHomes.Application.Roles.AssignPermission;

internal sealed class AssignPermissionCommandHandler(
    RoleManager<Role> roleManager,
    IRoleRepository roleRepository
) : ICommandHandler<AssignPermissionCommand>
{
    private readonly RoleManager<Role> _roleManager = roleManager;
    private readonly IRoleRepository _roleRepository = roleRepository;

    public async Task<Result> Handle(
        AssignPermissionCommand request,
        CancellationToken cancellationToken
    )
    {
        Role? role = await _roleManager.FindByNameAsync(request.RoleName);

        if (role is null)
        {
            return Result.Failure(Error.NotFound());
        }

        bool result = await _roleRepository.AddToPermissionAsync(role, request.PermissionNames) > 0;

        if (!result)
        {
            return Result.Failure(Error.Validation("Error Encountered"));
        }

        return Result.Success();
    }
}