using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Auditable;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.AuditConfigurations;

internal sealed class AuditEntryConfiguration : IEntityTypeConfiguration<AuditEntry>
{
    public void Configure(EntityTypeBuilder<AuditEntry> builder)
    {
        builder.ToTable(TableNames.SysAuditEntries);

        builder.HasKey(x => x.Id);
    }
}
