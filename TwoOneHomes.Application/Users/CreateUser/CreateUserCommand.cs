using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Domain.Constants;
using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Users.CreateUser;

[Authorize(Roles = RoleNames.SystemAdministrator)]
public sealed record CreateUserCommand(UserDto User)
    : IRequest<Result<Unit>>;