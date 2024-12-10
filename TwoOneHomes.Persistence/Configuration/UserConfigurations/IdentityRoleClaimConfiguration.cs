using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

public class IdentityRoleClaimConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<Ulid>>
{
    public void Configure(EntityTypeBuilder<IdentityRoleClaim<Ulid>> builder)
        => builder.ToTable("RoleClaims", "core");
}