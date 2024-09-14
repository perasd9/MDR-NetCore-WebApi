using BookWebApp.Application.Queries.ConfirmationQueries;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Handlers.ConfirmationQueriesHandlers
{
    public class GetAllConfirmationQueryHandler : IQueryHandler<GetAllConfirmationsQuery, IEnumerable<Confirmation>>
    {
        public Task<IEnumerable<Confirmation>> Handle(GetAllConfirmationsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
