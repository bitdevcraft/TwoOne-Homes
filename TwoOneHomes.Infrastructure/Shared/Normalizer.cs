using TwoOneHomes.Domain.Shared.Formatters;

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
