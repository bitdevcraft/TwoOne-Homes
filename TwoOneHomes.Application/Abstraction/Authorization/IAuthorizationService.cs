using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Abstraction.Authorization;

public interface IAuthorizationService
{
    Task<Result> AuthorizeCurrentUser(
        ICollection<string> requiredRoles,
        ICollection<string> requiredPermissions,
        ICollection<string> requiredPolicies
    );
}
