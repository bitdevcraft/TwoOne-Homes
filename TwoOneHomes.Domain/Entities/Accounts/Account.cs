using System.ComponentModel.DataAnnotations;
using TwoOneHomes.Domain.Entities.Accounts.Enums;
using TwoOneHomes.Domain.Entities.Inventories.Properties;
using TwoOneHomes.Domain.Primitives;
using TwoOneHomes.Domain.Users;

namespace TwoOneHomes.Domain.Entities.Accounts;

public class Account : Entity, IAuditableEntity
{
    public Account()
    {
    }

    public Account(User user) : this() => Owner = user;
    public DateTime CreatedOnUtc { get; set; }
    public DateTime? ModifiedOnUtc { get; set; }

    [MaxLength(255)] public string? Name { get; set; }

    public AccountType Type { get; set; }
    public AccountStatus Status { get; set; }

    public bool IsActive { get; set; }

    // Collection
    public ICollection<User>? Employees { get; set; }
    public ICollection<Property>? Properties { get; set; }
    public ICollection<Account>? SubAccounts { get; set; } = [];

    // Relationship
    public User? Owner { get; set; }
    public Account? ParentAccount { get; set; }
    public Ulid? ParentAccountId { get; set; }
}