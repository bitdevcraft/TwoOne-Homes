using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Abstraction.Messaging;

public interface ICommand : IRequest<Result> { }

public interface ICommand<TResponse> : IRequest<Result<TResponse>> { }
