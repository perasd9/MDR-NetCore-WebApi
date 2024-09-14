using MediatR;

namespace BookWebApp.Core.Interfaces.ApplicationInterfaces
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
    }
}
