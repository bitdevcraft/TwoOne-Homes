using System.ComponentModel.DataAnnotations;
using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Entities.Inventories.PaymentPlans.Enums;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Inventories.PaymentPlans;

public class PaymentPlanMilestone : Entity, IAuditableEntity, IAccountOwned
{
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public int Order { get; set; }
    public decimal TotalPercentage { get; set; }
    
    [Range(1, int.MaxValue)]
    public int PaymentCount { get; set; }
    
    public decimal Percentage => TotalPercentage / PaymentCount;
    
    public PaymentPlanMilestoneIntervalType IntervalType { get; set; }

    [Range(1, int.MaxValue)]
    public int IntervalCount { get; set; }

    public PaymentPlanMilestoneType Type { get; set; }

    public bool StartAfterHandover { get; set; }

    // Collection
    public ICollection<PaymentPlanMilestoneFee> MilestoneFees { get; set; } = [];
    
    // Relationship
    public PaymentPlan? PaymentPlan { get; set; }
    public Ulid? PaymentPlanId { get; set; }
    public Account? Owner { get; set; }
    public Ulid? OwnerId { get; set; }
    
    
}