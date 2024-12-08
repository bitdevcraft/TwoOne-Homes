using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Roles.AssignPermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record AssignPermissionCommand(string RoleName, IEnumerable<string> PermissionNames)
    : ICommand;