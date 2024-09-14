using MediatR;

namespace BookWebApp.Core.Interfaces.ApplicationInterfaces
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
