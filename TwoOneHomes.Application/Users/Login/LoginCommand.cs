using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Users.Login;

public sealed record LoginCommand(string Username, string Password)
    : IRequest<Result<LoginResponse>>;
