﻿using TwoOneHomes.Application.Users.LogActivity;
using TwoOneHomes.Application.Users.Login;
using TwoOneHomes.Application.Users.Register;
using TwoOneHomes.Application.Users.ValidateRefreshToken;
using TwoOneHomes.Domain.Constants;
using TwoOneHomes.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Presentation.Controllers;

public class AuthController(ISender sender) : ApiController(sender)
{
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var query = new RegisterCommand(request.Email, request.Username, request.Password);
        Result<Unit> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var query = new LoginCommand(request.Username, request.Password);
        Result<LoginResponse> result = await _sender.Send(query);

        SetRefreshToken(result.Value);

        return result.IsFailure ? HandleFailure(result) : Ok(CreateUserObject(result.Value));
    }

    [HttpPost("loginActivity")]
    public async Task<IActionResult> Log([FromBody] LogActivityRequest request)
    {
        var query = new LogActivityCommand(request.IpAddress, request.DeviceInfo, UserActivityTypes.Login);
        Result<Unit> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok(result.Value);
    }

    [HttpPost("refreshToken")]
    public async Task<IActionResult> RefreshToken()
    {
        string? refreshToken = Request.Cookies["refreshToken"];

        if (string.IsNullOrEmpty(refreshToken))
        {
            return BadRequest();
        }

        var query = new RefreshTokenCommand(refreshToken);
        Result<LoginResponse> result = await _sender.Send(query);

        SetRefreshToken(result.Value);

        return result.IsFailure ? HandleFailure(result) : Ok(CreateUserObject(result.Value));
    }

    private void SetRefreshToken(LoginResponse loginResponse)
    {
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddDays(7)
        };

        Response.Cookies.Append("refreshToken", loginResponse.RefreshToken, cookieOptions);
    }


    private static UserDto CreateUserObject(LoginResponse loginResponse) =>
        new(
            loginResponse.Username,
            loginResponse.Token
        );

    private sealed record UserDto(string UserName, string Token);
}