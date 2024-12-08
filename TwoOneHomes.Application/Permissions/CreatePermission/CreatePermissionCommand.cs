using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Permissions.CreatePermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record CreatePermissionCommand(string PermissionName) : ICommand;