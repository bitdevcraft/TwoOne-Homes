using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Permissions;

namespace TwoOneHomes.Application.Permissions.CreatePermission;

internal sealed class CreatePermissionCommandHandler(IPermissionRepository permissionRepository)
    : ICommandHandler<CreatePermissionCommand>
{
    private readonly IPermissionRepository _permissionRepository = permissionRepository;

    public async Task<Result> Handle(
        CreatePermissionCommand request,
        CancellationToken cancellationToken
    )
    {
        Permission? exists = await _permissionRepository.FindByNameAsync(request.PermissionName);

        if (exists != null)
        {
            return Result.Failure(Error.Validation("Permission Name Exists"));
        }

        bool result = await _permissionRepository.CreateAsync(request.PermissionName) > 0;

        if (!result)
        {
            return Result.Failure(Error.Validation("Failed to create Permission"));
        }

        return Result.Success();
    }
}