using TwoOneHomes.Domain.Entities.Inventories;
using TwoOneHomes.Domain.Entities.Inventories.Properties;
using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Entities.Accounts;

public class Account : Entity, IAuditableEntity
{
    public Account(User user)  => Owner = user;
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    public string? Name { get; set; }

    public AccountType Type { get; set; }
    public bool IsActive { get; set; }

    // Collection
    public ICollection<User> Employees { get; set; } = [];
    public ICollection<BaseProperty> Properties { get; set; } = [];
    public ICollection<Account> SubAccounts { get; set; } = [];
    
    // Relationship
    public User Owner { get; set; }
    public Ulid OwnerId { get; set; }

    public Account? ParentAccount { get; set; }
    public Ulid? ParentAccountId { get; set; }

    
}
