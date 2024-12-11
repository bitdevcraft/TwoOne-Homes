using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Persistence.Repositories;

internal abstract class GenericRepository<TEntity>(ApplicationDbContext dbContext)
    where TEntity : Entity
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<List<TEntity>> GetListAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        CancellationToken cancellationToken = default
    )
    {
        IQueryable<TEntity> query = _dbContext
            .Set<TEntity>()
            .AsNoTracking()
            .AsQueryable();

        if (filter is not null)
        {
            query = query.Where(filter);
        }
        
        return await query.ToListAsync(cancellationToken);
    }
    
    public async Task<TEntity?> GetByIdAsync(
        Ulid Id,
        CancellationToken cancellationToken = default
    )
        =>
            await _dbContext
                .Set<TEntity>()
                .FirstOrDefaultAsync(e => e.Id == Id, cancellationToken);

    public void Add(TEntity entity)
        => _dbContext.Set<TEntity>().Add(entity);

    public void Delete(TEntity entity)
        => _dbContext.Remove(entity);

    public void Update(TEntity entity)
        => _dbContext.Set<TEntity>().Update(entity);
}