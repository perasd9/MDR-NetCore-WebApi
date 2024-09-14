using BookWebApp.Application.Queries.BookQueries;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Handlers.BookQueriesHandlers
{
    public class GetAllBooksForUserQueryHandler : IQueryHandler<GetAllBooksForUserQuery, IEnumerable<Book>>
    {
        public Task<IEnumerable<Book>> Handle(GetAllBooksForUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
