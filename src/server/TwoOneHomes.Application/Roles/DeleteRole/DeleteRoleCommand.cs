using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Roles.DeleteRole;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record DeleteRoleCommand(string Name) : ICommand;