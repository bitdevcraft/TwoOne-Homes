using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Constants;

namespace TwoOneHomes.Application.Users.ListUser;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public record ListUserQuery() : IQuery<List<UserListDto>>;