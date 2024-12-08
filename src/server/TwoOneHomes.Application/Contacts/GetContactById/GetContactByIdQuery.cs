using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Caching;
using TwoOneHomes.Application.Common.PermissionType;
using TwoOneHomes.Domain.Constants;
using TwoOneHomes.Domain.Entities;

namespace TwoOneHomes.Application.Contacts.GetContactById;

[Authorize(Permissions = PermissionType.Contacts.View, Roles = RoleNames.SystemAdministrator)]
public sealed record GetContactByIdQuery(Ulid Id) : ICachedQuery<Contact>
{
    public string CacheKey => $"contacts-{Id}";

    public TimeSpan? Expiration => null;
}
