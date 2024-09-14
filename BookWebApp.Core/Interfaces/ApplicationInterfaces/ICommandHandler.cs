using MediatR;

namespace BookWebApp.Core.Interfaces.ApplicationInterfaces
{
    public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse> where TCommand : ICommand<TResponse>
    {
    }
}
