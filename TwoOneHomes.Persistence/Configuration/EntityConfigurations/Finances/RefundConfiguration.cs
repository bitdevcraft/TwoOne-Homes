using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Finances.Refunds;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Finances;

public class RefundConfiguration : IEntityTypeConfiguration<Refund> 
{
    public void Configure(EntityTypeBuilder<Refund> builder)
    {
        builder.ToTable("Refunds");
        builder.HasKey(x => x.Id);
    }
}