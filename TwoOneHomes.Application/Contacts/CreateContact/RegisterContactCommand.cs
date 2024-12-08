using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Application.Common.PermissionType;
using TwoOneHomes.Domain.Constants;
using TwoOneHomes.Domain.Entities;

namespace TwoOneHomes.Application.Contacts.CreateContact;

[Authorize(Permissions = PermissionType.Contacts.Create, Roles = RoleNames.SystemAdministrator)]
public sealed record RegisterContactCommand(Contact Contact) : ICommand<Ulid>;
