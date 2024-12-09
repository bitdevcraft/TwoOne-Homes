using TwoOneHomes.Application.Abstraction.Authentication;
using TwoOneHomes.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;
using TwoOneHomes.Domain.Users.Tokens;

namespace TwoOneHomes.Application.Users.Login;

public class LoginCommandHandler(
    UserManager<User> userManager,
    IJwtProvider jwtProvider,
    IRefreshTokenProvider refreshTokenProvider)
    : IRequestHandler<LoginCommand, Result<LoginResponse>>
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly IJwtProvider _jwtProvider = jwtProvider;
    private readonly IRefreshTokenProvider _refreshTokenProvider = refreshTokenProvider;

    public async Task<Result<LoginResponse>> Handle(
        LoginCommand request,
        CancellationToken cancellationToken
    )
    {
        User? user = await _userManager.FindByNameAsync(request.Username);

        if (user == null)
        {
            return Result.Failure<LoginResponse>(Error.Unauthorized());
        }

        bool result = await _userManager.CheckPasswordAsync(user, request.Password);

        if (!result)
        {
            return Result.Failure<LoginResponse>(Error.Unauthorized());
        }

        IList<string> roles = await _userManager.GetRolesAsync(user);

        string refreshToken = _refreshTokenProvider.GenerateRefreshToken();
        string token = _jwtProvider.Generate(user, roles);

        user.RefreshTokens.Add(new RefreshToken { User = user, Token = refreshToken });

        await _userManager.UpdateAsync(user);

        return new LoginResponse(request.Username, token, refreshToken);
    }
}