using BookWebApp.Application.Queries.BookQueries;
using BookWebApp.Application.Queries.ConfirmationQueries;
using BookWebApp.Core.Domain;
using MediatR;

namespace BookWebApp.Presentation.GraphQL.GraphQLQueries
{
    public class Query
    {
        public async Task<List<Book>> GetBooks([Service] ISender sender)
        {
            return (await sender.Send(new GetAllBooksQuery())).ToList();
        }

        public async Task<List<Confirmation>> GetConfirmations([Service] ISender sender)
        {
            return (await sender.Send(new GetAllConfirmationsQuery())).ToList();
        }
    }
}
