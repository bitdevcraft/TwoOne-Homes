using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Contacts.CreateContact;

internal sealed class RegisterContactCommandHandler(
    IContactRepository contactRepository,
    IUnitOfWork unitOfWork
) : ICommandHandler<RegisterContactCommand, Ulid>
{
    private readonly IContactRepository _contactRepository = contactRepository;

    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<Ulid>> Handle(
        RegisterContactCommand request,
        CancellationToken cancellationToken
    )
    {
        _contactRepository.Add(request.Contact);
        _ = await _unitOfWork.SaveChangesAsync(cancellationToken);

        return request.Contact.Id;
    }
}