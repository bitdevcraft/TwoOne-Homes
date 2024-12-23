using TwoOneHomes.Application.Abstraction.Authentication;
using TwoOneHomes.Application.Users.Login;
using TwoOneHomes.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TwoOneHomes.Domain.Repositories.Identities;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Tokens;

namespace TwoOneHomes.Application.Users.ValidateRefreshToken;

public class RefreshTokenCommandHandler(
    IRefreshTokenRepository refreshTokenRepository,
    UserManager<User> userManager,
    IRefreshTokenProvider refreshTokenProvider,
    IJwtProvider jwtProvider)
    : IRequestHandler<RefreshTokenCommand, Result<LoginResponse>>
{
    private readonly IRefreshTokenRepository _refreshTokenRepository = refreshTokenRepository;
    private readonly UserManager<User> _userManager = userManager;
    private readonly IRefreshTokenProvider _refreshTokenProvider = refreshTokenProvider;
    private readonly IJwtProvider _jwtProvider = jwtProvider;

    public async Task<Result<LoginResponse>> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
    {
        RefreshToken? refreshToken = await _refreshTokenRepository.GetRefreshToken(request.RefreshToken);

        if (refreshToken is null)
        {
            return Result.Failure<LoginResponse>(Error.Unauthorized());
        }

        if (refreshToken.User.UserName is null)
        {
            return Result.Failure<LoginResponse>(Error.Unauthorized());
        }

        string newRefreshToken = _refreshTokenProvider.GenerateRefreshToken();

        IList<string> roles = await _userManager.GetRolesAsync(refreshToken.User);

        string token = _jwtProvider.Generate(refreshToken.User, roles);

        refreshToken.User.RefreshTokens.Add(new RefreshToken { User = refreshToken.User, Token = newRefreshToken });

        _ = await _userManager.UpdateAsync(refreshToken.User);

        return new LoginResponse(refreshToken.User.UserName, token, newRefreshToken);
    }
}