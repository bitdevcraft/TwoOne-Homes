﻿namespace TwoOneHomes.Application.Users.Login;

public record LoginResponse(string Username, string Token, string RefreshToken);