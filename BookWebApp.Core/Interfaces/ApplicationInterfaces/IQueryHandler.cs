using MediatR;

namespace BookWebApp.Core.Interfaces.ApplicationInterfaces
{
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse> 
    {
    }
}
