using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

namespace TwoOneHomes.Persistence.Configuration.EntityConfigurations.Inventories.PaymentPlans;

public class PaymentPlanConfiguration : IEntityTypeConfiguration<PaymentPlan>
{
    public void Configure(EntityTypeBuilder<PaymentPlan> builder)
    {
        builder.ToTable("PaymentPlans");
        builder.HasKey(x => x.Id);
        
        builder.HasMany(x => x.Projects)
            .WithOne(x => x.PaymentPlan)
            .HasForeignKey(x => x.PaymentPlanId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}