using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Inventories.PaymentPlans;

public class PaymentPlanMilestoneFeeConfiguration : IEntityTypeConfiguration<PaymentPlanMilestoneFee>
{
    public void Configure(EntityTypeBuilder<PaymentPlanMilestoneFee> builder)
    {
        builder.ToTable("PaymentPlanMilestoneFees");
        builder.HasKey(x => x.Id);
    }
}