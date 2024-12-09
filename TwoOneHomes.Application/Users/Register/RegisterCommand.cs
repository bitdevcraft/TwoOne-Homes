using MediatR;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Users.Register;

public sealed record RegisterCommand(string Email, string Username, string Password)
    : IRequest<Result<Unit>>;
