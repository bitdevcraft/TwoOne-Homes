using AutoMapper;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Entities;
using TwoOneHomes.Domain.Repositories;
using MediatR;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Contacts.UpdateContactById;

public class UpdateContactByIdCommandHandler(
    IContactRepository contactRepository,
    IMapper mapper,
    IUnitOfWork unitOfWork
) : ICommandHandler<UpdateContactByIdCommand, Unit>
{
    private readonly IContactRepository _contactRepository = contactRepository;
    private readonly IMapper _mapper = mapper;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public async Task<Result<Unit>> Handle(
        UpdateContactByIdCommand request,
        CancellationToken cancellationToken
    )
    {
        Contact? contact = await _contactRepository.GetByIdAsync(request.Id, cancellationToken);

        if (contact == null)
        {
            return Result.Failure<Unit>(Error.NotFound());
        }

        _ = _mapper.Map(request.Contact, contact);

        bool result = await _unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        if (!result)
        {
            return Result.Failure<Unit>(Error.Validation("Update Error"));
        }

        return Unit.Value;
    }
}