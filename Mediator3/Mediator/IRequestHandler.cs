﻿namespace Mediator3.Mediator
{
    public interface IRequestHandler <in TRequest, TResponse> where TRequest : IRequest<TResponse>
    {

    }
}
