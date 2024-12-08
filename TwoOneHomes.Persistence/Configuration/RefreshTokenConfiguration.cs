using TwoOneHomes.Domain.Users;
using TwoOneHomes.Persistence.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TwoOneHomes.Persistence.Configuration;

internal sealed class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.ToTable(TableNames.SysRefreshTokens);

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Expires);
    }
}