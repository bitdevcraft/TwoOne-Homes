using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

public class IdentityUserClaimConfiguration : IEntityTypeConfiguration<IdentityUserClaim<Ulid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserClaim<Ulid>> builder) 
        => builder.ToTable("UserClaims", "core");
}