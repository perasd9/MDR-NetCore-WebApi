using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Commands.BookCommands
{
    public class CreateBookCommand : ICommand<Book>
    {
        public Book? Book { get; set; }
        public Guid UserId { get; set; }
    }
}
