using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Inventories.PaymentPlans;

public class PaymentPlanMilestoneConfiguration : IEntityTypeConfiguration<PaymentPlanMilestone>
{
    public void Configure(EntityTypeBuilder<PaymentPlanMilestone> builder)
    {
        builder.ToTable("PaymentPlanMilestones");
        builder.HasKey(x => x.Id);

        // builder.HasIndex(x 
        //     => new { x.Order, x.PaymentPlanId })
        //     .IsUnique();
    }
}