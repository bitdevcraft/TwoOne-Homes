using TwoOneHomes.Application.Abstraction.UserAccess;
using TwoOneHomes.Infrastructure.Extensions;
using Microsoft.AspNetCore.Http;

namespace TwoOneHomes.Infrastructure.Security.UserAccess;

public class UserContext(IHttpContextAccessor httpContextAccessor) : IUserContext
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public Guid UserId =>
        _httpContextAccessor.HttpContext?.User.GetUserId()
        ?? throw new InvalidOperationException("User context is unavailable");

    public string IdentityId =>
        _httpContextAccessor.HttpContext?.User.GetIdentityId()
        ?? throw new InvalidOperationException("User context is unavailable");
}
