using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Users.Register;

public sealed record RegisterCommand(string Email, string Username, string Password)
    : IRequest<Result<Unit>>;
