using TwoOneHomes.Domain.Entities.Accounts;

namespace TwoOneHomes.Domain.Primitives;

public interface IAccountOwned
{
    public Account? Owner { get; set; }
    public Ulid? OwnerId { get; set; }
}