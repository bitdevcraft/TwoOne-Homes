using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Finances.Commissions;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Finances;

public class CommissionConfiguration : IEntityTypeConfiguration<Commission>
{
    public void Configure(EntityTypeBuilder<Commission> builder)
    {
        builder.ToTable("Commissions");
        builder.HasKey(x => x.Id);
    }
}