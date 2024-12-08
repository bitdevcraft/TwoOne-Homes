using TwoOneHomes.Application.Abstraction.Messaging;

namespace TwoOneHomes.Application.Abstraction.Caching;

public interface ICachedQuery<TResponse> : IQuery<TResponse>, ICachedQuery { }

public interface ICachedQuery
{
    string CacheKey { get; }

    TimeSpan? Expiration { get; }
}
