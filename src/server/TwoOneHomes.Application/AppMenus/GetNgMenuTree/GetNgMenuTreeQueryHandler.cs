using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.Repositories;
using TwoOneHomes.Domain.Shared;

namespace TwoOneHomes.Application.AppMenus.GetNgMenuTree;

public class GetNgMenuTreeQueryHandler(INgMenuRepository ngMenuRepository) : IQueryHandler<GetNgMenuTreeQuery, string>
{
    private readonly INgMenuRepository _ngMenuRepository = ngMenuRepository;

    public Task<Result<string>> Handle(GetNgMenuTreeQuery request, CancellationToken cancellationToken) =>
        Task.FromResult(Result.Create(_ngMenuRepository.GetTreeNode()));
}