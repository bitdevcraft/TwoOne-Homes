using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.AppMenus.GetNgMenu;

public class GetNgMenuQueryHandler(INgMenuRepository ngMenuRepository) : IQueryHandler<GetNgMenuQuery, string>
{
    private readonly INgMenuRepository _ngMenuRepository = ngMenuRepository;

    public Task<Result<string>> Handle(GetNgMenuQuery request, CancellationToken cancellationToken) =>
        Task.FromResult(Result.Create(_ngMenuRepository.GetRootNode()));
}