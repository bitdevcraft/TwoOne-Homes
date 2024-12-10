using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Users.Roles;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

internal class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder) =>
        builder.ToTable("UserRoles", "core");
}
