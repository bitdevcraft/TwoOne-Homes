using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Abstraction.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>> { }
