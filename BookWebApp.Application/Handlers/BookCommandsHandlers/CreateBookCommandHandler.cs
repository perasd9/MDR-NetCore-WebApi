using BookWebApp.Application.Commands.BookCommands;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.UnitOfWork;

namespace BookWebApp.Application.Handlers.BookCommandsHandlers
{
    public class CreateBookCommandHandler : ICommandHandler<CreateBookCommand, Book>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateBookCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Book> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.BookRepository.Save(request.Book!);
            await _unitOfWork.SaveChangesAsync();

            return request.Book!;
        }
    }
}
