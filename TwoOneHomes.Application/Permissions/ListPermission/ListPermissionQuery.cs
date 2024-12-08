using System.Collections;
using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Permissions.ListPermission;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record ListPermissionQuery : IQuery<Hashtable>;
