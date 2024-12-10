using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Entities.Inventories.Properties;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Inventories.Projects;

public class Project : Entity, IAuditableEntity, IAccountOwned
{
    public Project()
    {
        
    }
    public Project(Account owner)
    {
        Owner = owner;
        OwnerId = owner.Id;
    }
    
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public string? Name { get; set; }
    
    // Collection
    public ICollection<Property> Properties { get; set; } = [];
    public ICollection<ProjectInstallmentPlan>? PaymentPlans { get; set; }
    
    // Relationship
    public Account? Owner { get; set; }
    public Ulid OwnerId { get; set; }
}
