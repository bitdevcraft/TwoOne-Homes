using MediatR;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Application.Abstraction.Messaging;

public interface ICommand : IRequest<Result> { }

public interface ICommand<TResponse> : IRequest<Result<TResponse>> { }
