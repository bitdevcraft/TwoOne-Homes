using MediatR;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Abstraction.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>> { }
