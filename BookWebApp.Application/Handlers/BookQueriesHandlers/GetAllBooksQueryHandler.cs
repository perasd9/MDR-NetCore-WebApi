using BookWebApp.Application.Queries.BookQueries;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.UnitOfWork;

namespace BookWebApp.Application.Handlers.BookQueriesHandlers
{
    public class GetAllBooksQueryHandler : IQueryHandler<GetAllBooksQuery, IEnumerable<Book>>
    {
        private IUnitOfWork _unitOfWork;

        public GetAllBooksQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Book>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_unitOfWork.BookRepository.GetAll());
        }
    }
}
