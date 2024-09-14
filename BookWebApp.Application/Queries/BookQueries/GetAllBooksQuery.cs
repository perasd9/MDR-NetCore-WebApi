using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Queries.BookQueries
{
    public class GetAllBooksQuery : IQuery<IEnumerable<Book>>
    {
    }
}
