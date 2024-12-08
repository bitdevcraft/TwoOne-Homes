using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Roles.GetRolePermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record GetRolePermissionQuery(string RoleName) : IQuery<List<string>>;