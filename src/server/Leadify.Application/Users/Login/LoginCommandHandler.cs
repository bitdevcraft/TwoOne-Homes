﻿using Leadify.Application.Abstraction.Authentication;
using Leadify.Domain.Shared;
using Leadify.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Leadify.Application.Users.Login;

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

        user.RefreshTokens.Add(new Domain.Users.RefreshToken { User = user, Token = refreshToken });

        await _userManager.UpdateAsync(user);

        return new LoginResponse(request.Username, token, refreshToken);
    }
}