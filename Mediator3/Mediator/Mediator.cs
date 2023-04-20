namespace Mediator3.Mediator
{
    public class Mediator : IMediator
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public Mediator(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request)
        {
            using var scope = _serviceScopeFactory.CreateScope();
            var handleType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
            var handler = (dynamic)scope.ServiceProvider.GetService(handleType);
            return await handler.Handle((dynamic)request);
        }
    }
}
