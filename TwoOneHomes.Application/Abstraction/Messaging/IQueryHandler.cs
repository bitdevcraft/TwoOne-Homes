﻿using TwoOneHomes.Domain.Shared;
using MediatR;

namespace TwoOneHomes.Application.Abstraction.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}