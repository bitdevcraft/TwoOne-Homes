using Microsoft.AspNetCore.Identity;

namespace TwoOneHomes.Domain.Users.Roles;

public class Role : IdentityRole<Ulid>
{
    public Role() => Id = Ulid.NewUlid();

    public Role(string name)
        : this() => Name = name;

    public virtual ICollection<UserRole>? UserRoles { get; set; }
    public virtual ICollection<RolePermission>? RolePermissions { get; set; }
}
