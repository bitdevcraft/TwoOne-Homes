using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Auditable;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.AuditConfigurations;

internal sealed class AuditConfiguration : IEntityTypeConfiguration<Audit>
{
    public void Configure(EntityTypeBuilder<Audit> builder)
    {
        builder.ToTable(TableNames.SysAudits);

        builder.HasKey(x => x.Id);
    }
}
