using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Users.Roles;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

internal class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
{
    public void Configure(EntityTypeBuilder<RolePermission> builder)
    {
        builder.ToTable("RolePermissions", "core");

        builder.HasKey(rolePermission => new
        {
            rolePermission.RoleId,
            rolePermission.PermissionId
        });
    }
}
