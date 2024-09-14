using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Queries.BookQueries
{
    public class GetAllBooksForUserQuery : IQuery<IEnumerable<Book>>
    {
        public Guid UserId { get; set; }
    }
}
