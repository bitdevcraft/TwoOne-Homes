using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

public class IdentityUserLoginConfiguration : IEntityTypeConfiguration<IdentityUserLogin<Ulid>>
{
    public void Configure(EntityTypeBuilder<IdentityUserLogin<Ulid>> builder) 
        => builder.ToTable("UserLogins", "core");
}