using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Repositories;
using Microsoft.AspNetCore.Identity;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Roles;

namespace TwoOneHomes.Application.Roles.AssignUsers;

internal sealed class AssignUsersCommandHandler(
    IRoleRepository roleRepository,
    RoleManager<Role> roleManager
) : ICommandHandler<AssignUsersCommand>
{
    private readonly IRoleRepository _roleRepository = roleRepository;
    private readonly RoleManager<Role> _roleManager = roleManager;

    public async Task<Result> Handle(
        AssignUsersCommand request,
        CancellationToken cancellationToken
    )
    {
        Role? role = await _roleManager.FindByNameAsync(request.RoleName);

        if (role is null)
        {
            return Result.Failure(Error.NotFound());
        }

        bool result = await _roleRepository.AddUsersAsync(role, request.UserId.Select(Id => Ulid.Parse(Id))) > 0;

        if (!result)
        {
            return Result.Failure(Error.Validation("Error Encountered"));
        }

        return Result.Success();
    }
}