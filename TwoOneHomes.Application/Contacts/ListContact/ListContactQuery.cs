using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Application.Common.PermissionType;
using TwoOneHomes.Domain.Constants;
using TwoOneHomes.Domain.Entities;

namespace TwoOneHomes.Application.Contacts.ListContact;

[Authorize(Permissions = PermissionType.Contacts.View, Roles = RoleNames.SystemAdministrator)]
public sealed record ListContactQuery() : IQuery<List<Contact>>;
