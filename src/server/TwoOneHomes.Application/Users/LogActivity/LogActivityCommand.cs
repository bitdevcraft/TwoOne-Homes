using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Users.LogActivity;

public sealed record LogActivityCommand(string IpAddress, string DeviceInfo, string ActivityType)
    : IRequest<Result<Unit>>;