using TwoOneHomes.Application.Users.Login;
using MediatR;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Users.ValidateRefreshToken;

public record RefreshTokenCommand(string RefreshToken) : IRequest<Result<LoginResponse>>;