using BookWebApp.Application.Commands.BookCommands;
using BookWebApp.Application.Commands.ConfirmationCommands;
using BookWebApp.Core.Domain;
using BookWebApp.Presentation.GraphQL.GraphQLMutations.BookInputs;
using BookWebApp.Presentation.GraphQL.GraphQLMutations.ConfirmationInputs;
using MediatR;

namespace BookWebApp.Presentation.GraphQL.GraphQLMutations
{
    public class Mutation
    {
        public async Task<Book> AddBook(AddBookInput bookInput, [Service] ISender sender)
        {
            var createdBook = await sender.Send(new CreateBookCommand()
            {
                Book = new Book()
                {
                    BookName = bookInput.BookName,
                    BookDescription = bookInput.BookDescription,
                    NumberOfCopies = bookInput.NumberOfCopies,
                    Author = bookInput.Author,
                    BookType = bookInput.BookType,
                }
            });

            return createdBook;
        }

        public async Task<Confirmation> AddConfirmation(AddConfirmationInput confirmationInput, [Service] ISender sender)
        {
            var createdConfirmation = await sender.Send(new CreateConfirmationCommand()
            {
                Confirmation = new Confirmation()
                {
                    ConfirmationNumber = confirmationInput.ConfirmationNumber,
                    DateFrom = confirmationInput.DateFrom,
                    DateTo = confirmationInput.DateTo,
                    Processed = confirmationInput.Processed,
                    BookId = confirmationInput.BookId,
                    LibrarianId = confirmationInput.LibrarianId,
                    UserId = confirmationInput.UserId
                }
            });

            return createdConfirmation;
        }
    }
}
