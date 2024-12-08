using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans.Enums;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

public class PaymentPlanMilestoneFee : Entity, IAuditableEntity
{
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }
    
    public string? Name { get; set; }
    public decimal AmountOrRate { get; set; }
    public bool IsRecurring  { get; set; }
    public PaymentPlanMilestoneFeeType Type { get; set; }
    
    // Relationship
    public PaymentPlanMilestone? Milestone { get; set; }
    public Ulid? MilestoneId { get; set; }
}