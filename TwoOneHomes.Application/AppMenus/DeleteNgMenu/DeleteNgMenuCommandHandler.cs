using TwoOneHomes.Application.Abstraction.Caching;
using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.ClientAppLayout;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.AppMenus.DeleteNgMenu;

public class DeleteNgMenuCommandHandler(
    INgMenuRepository ngMenuRepository,
    IUnitOfWork unitOfWork,
    ICacheService cacheService)
    : ICommandHandler<DeleteNgMenuCommand>
{
    private readonly INgMenuRepository _ngMenuRepository = ngMenuRepository;
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly ICacheService _cacheService = cacheService;

    public async Task<Result> Handle(DeleteNgMenuCommand request, CancellationToken cancellationToken)
    {
        NgMenu? result = await _ngMenuRepository.GetByIdAsync(Ulid.Parse(request.Id), cancellationToken);

        if (result is null)
        {
            return Result.Failure(Error.Validation("Parent doesn't exist"));
        }

        _ngMenuRepository.Delete(result);

        await _cacheService.RemoveAsync("AppMenu-Root", cancellationToken);

        _ = await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}