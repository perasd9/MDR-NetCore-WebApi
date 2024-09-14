using BookWebApp.Application.Queries.BookQueries;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Handlers.BookQueriesHandlers
{
    public class GetAllBooksQueryHandler : IQueryHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        public Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
