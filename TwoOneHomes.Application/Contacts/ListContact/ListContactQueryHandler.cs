using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Entities;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared;

namespace TwoOneHomes.Application.Contacts.ListContact;

public class ListContactQueryHandler(IContactRepository contactRepository)
    : IQueryHandler<ListContactQuery, List<Contact>>
{
    private readonly IContactRepository _contactRepository = contactRepository;

    public async Task<Result<List<Contact>>> Handle(
        ListContactQuery request,
        CancellationToken cancellationToken
    ) => await _contactRepository.GetAllContactAsync(cancellationToken);
}
