using BookWebApp.Application.Commands.BookCommands;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Handlers.BookCommandsHandlers
{
    public class CreateBookCommandHandler : ICommandHandler<CreateBookCommand, Book>
    {
        public Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
