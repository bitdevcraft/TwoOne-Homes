using TwoOneHomes.Domain.Entities.Accounts;
using TwoOneHomes.Domain.Entities.Accounts.Enums;
using TwoOneHomes.Domain.Entities.Bookings;
using TwoOneHomes.Domain.Entities.Inventories.Projects;
using TwoOneHomes.Domain.Entities.Inventories.Properties.Enums;
using TwoOneHomes.Domain.Entities.Inventories.Properties.Validation;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Entities.Inventories.Properties;

public class BaseProperty : Entity, IAuditableEntity, IAccountOwned
{
    public BaseProperty()
    {
        
    }
    public BaseProperty(Account account)
    {
        Owner = account;
        OwnerId = account.Id;
    }
    
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public bool IsActive => Owner is not null 
                            && (Owner.Type == AccountType.Seller 
                                || Owner.Type == AccountType.BrokerAndSeller)  
                            && IsListed;
    public bool IsListed => Status == PropertyStatus.Available;

    // Details
    public string? Name { get; set; }
    public string? Description { get; set; }
   
    
    public PropertyType? Type { get; set; }
    public PropertyCategory Category { get; set; }

    [PropertyCategoryStatusValidation(nameof(Category))]
    public PropertyStatus Status { get; set; } = PropertyStatus.Unavailable;

    // Relationship
    public Account? Owner { get; set; }
    public Ulid? OwnerId { get; set; }

    public Project? Project { get; set; }
    public Ulid? ProjectId { get; set; }
    
    // Collection
    public ICollection<Booking> Bookings { get; set; } = [];

}