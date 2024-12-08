using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Roles.CreateRole;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public sealed record class CreateRoleCommand(string RoleName) : ICommand;