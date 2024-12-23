using TwoOneHomes.Application.Abstraction.Caching;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.ClientAppLayout;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.AppMenus.CreateNgMenu;

public class CreateNgMenuCommandHandler(
    INgMenuRepository ngMenuRepository,
    IUnitOfWork unitOfWork,
    ICacheService cacheService)
    : ICommandHandler<CreateNgMenuCommand>
{
    private readonly INgMenuRepository _ngMenuRepository = ngMenuRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly ICacheService _cacheService = cacheService;

    public async Task<Result> Handle(CreateNgMenuCommand request, CancellationToken cancellationToken)
    {
        if (request.Menu.ParentId is not null)
        {
            NgMenu? result = await _ngMenuRepository.GetByIdAsync(request.Menu.ParentId, cancellationToken);
            if (result is null)
            {
                return Result.Failure(Error.Validation("Parent doesn't exist"));
            }

            request.Menu.Parent = result;
        }

        _ngMenuRepository.Add(request.Menu);

        await _cacheService.RemoveAsync("AppMenu-Root", cancellationToken);

        bool success = await _unitOfWork.SaveChangesAsync(cancellationToken) > 0;

        if (!success)
        {
            return Result.Failure(Error.Validation("Something went wrong"));
        }

        return Result.Success();
    }
}