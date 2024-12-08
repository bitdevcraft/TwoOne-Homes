using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Application.Common.PermissionType;
using TwoOneHomes.Domain.Constants;
using TwoOneHomes.Domain.Entities;
using MediatR;

namespace TwoOneHomes.Application.Contacts.UpdateContactById;

[Authorize(Permissions = PermissionType.Contacts.Edit, Roles = RoleNames.SystemAdministrator)]
public sealed record UpdateContactByIdCommand(Ulid Id, Contact Contact) : ICommand<Unit>;
