using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

public class PaymentPlan : Entity, IAccountOwned, IAuditableEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    
    public Account? Owner { get; set; }
    public Ulid? OwnerId { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }
    
    public ICollection<PaymentPlanMilestone> PaymentPlanMilestones { get; set; } = [];
}
