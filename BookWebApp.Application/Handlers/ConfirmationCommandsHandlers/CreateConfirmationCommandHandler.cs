using BookWebApp.Application.Commands.ConfirmationCommands;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Handlers.ConfirmationCommandsHandlers
{
    public class CreateConfirmationCommandHandler : ICommandHandler<CreateConfirmationCommand, Confirmation>
    {
        public Task<Confirmation> Handle(CreateConfirmationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
