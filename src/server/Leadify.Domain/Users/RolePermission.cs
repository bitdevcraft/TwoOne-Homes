﻿namespace Leadify.Domain.Users;

public class RolePermission
{
    public RolePermission() => Id = Ulid.NewUlid();

    public Ulid Id { get; set; }
    public virtual required Role Role { get; set; }
    public virtual Ulid RoleId { get; set; }
    public virtual required Permission Permission { get; set; }
    public virtual Ulid PermissionId { get; set; }
}
