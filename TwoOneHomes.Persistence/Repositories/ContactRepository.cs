using TwoOneHomes.Domain.Entities;
using TwoOneHomes.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TwoOneHomes.Persistence.Repositories;

public class ContactRepository(ApplicationDbContext dbContext) : IContactRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<List<Contact>> GetAllContactAsync(
        CancellationToken cancellationToken = default
    ) => await _dbContext.Set<Contact>().ToListAsync(cancellationToken);

    public async Task<Contact?> GetByIdAsync(
        Ulid Id,
        CancellationToken cancellationToken = default
    ) =>
        await _dbContext
            .Set<Contact>()
            .FirstOrDefaultAsync(contact => contact.Id == Id, cancellationToken);

    public void Add(Contact contact) => _dbContext.Set<Contact>().Add(contact);

    public void Delete(Contact contact) => _dbContext.Remove(contact);

    public void Update(Contact contact) => _dbContext.Set<Contact>().Update(contact);
}
