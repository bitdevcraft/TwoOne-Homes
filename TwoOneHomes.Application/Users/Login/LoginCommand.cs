using MediatR;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Users.Login;

public sealed record LoginCommand(string Username, string Password)
    : IRequest<Result<LoginResponse>>;
