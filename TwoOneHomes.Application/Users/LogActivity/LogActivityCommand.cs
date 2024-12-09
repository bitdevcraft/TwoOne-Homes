using MediatR;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Users.LogActivity;

public sealed record LogActivityCommand(string IpAddress, string DeviceInfo, string ActivityType)
    : IRequest<Result<Unit>>;