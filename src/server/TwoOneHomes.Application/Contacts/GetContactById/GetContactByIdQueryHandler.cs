using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Entities;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared;

namespace TwoOneHomes.Application.Contacts.GetContactById;

internal sealed class GetContactByIdQueryHandler(IContactRepository contactRepository)
    : IQueryHandler<GetContactByIdQuery, Contact>
{
    private readonly IContactRepository _contactRepository = contactRepository;

    public async Task<Result<Contact>> Handle(
        GetContactByIdQuery request,
        CancellationToken cancellationToken
    )
    {
        Contact? contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact is null)
        {
            return Result.Failure<Contact>(Error.NotFound());
        }

        return contact;
    }
}
