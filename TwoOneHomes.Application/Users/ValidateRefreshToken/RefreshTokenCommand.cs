using TwoOneHomes.Application.Users.Login;
using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Users.ValidateRefreshToken;

public record RefreshTokenCommand(string RefreshToken) : IRequest<Result<LoginResponse>>;