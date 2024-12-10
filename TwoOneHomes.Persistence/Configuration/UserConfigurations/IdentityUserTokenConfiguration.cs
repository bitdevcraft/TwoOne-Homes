using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

public class IdentityUserTokenConfiguration : IEntityTypeConfiguration<IdentityUserToken<Ulid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserToken<Ulid>> builder) 
        => builder.ToTable("IdentityUserTokens", "core");
}