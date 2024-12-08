using TwoOneHomes.Domain.Shared;

namespace TwoOneHomes.Infrastructure.Shared;

public class Normalizer : INormalizer
{
    public string? NormalizeName(string? name)
    {
        if (name == null)
        {
            return null;
        }
        return name.Normalize().ToUpperInvariant();
    }
}
