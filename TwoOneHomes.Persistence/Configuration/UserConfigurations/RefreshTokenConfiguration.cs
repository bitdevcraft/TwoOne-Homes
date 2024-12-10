using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Users.Tokens;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.UserConfigurations;

internal sealed class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.ToTable("RefreshTokens", "core");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Expires);
    }
}