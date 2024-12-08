using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Roles.AssignUsers;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record AssignUsersCommand(string RoleName, IEnumerable<string> UserId) : ICommand;