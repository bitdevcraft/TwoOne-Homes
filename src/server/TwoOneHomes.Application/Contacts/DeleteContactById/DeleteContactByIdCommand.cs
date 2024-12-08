using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Application.Common.PermissionType;
using TwoOneHomes.Domain.Constants;
using MediatR;

namespace TwoOneHomes.Application.Contacts.DeleteContactById;

[Authorize(Permissions = PermissionType.Contacts.Delete, Roles = RoleNames.SystemAdministrator)]
public sealed record DeleteContactByIdCommand(Ulid Id) : ICommand<Unit>;
