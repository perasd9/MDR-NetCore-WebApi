using BookWebApp.Application.Queries.ConfirmationQueries;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.UnitOfWork;

namespace BookWebApp.Application.Handlers.ConfirmationQueriesHandlers
{
    public class GetAllConfirmationQueryHandler : IQueryHandler<GetAllConfirmationsQuery, IEnumerable<Confirmation>>
    {
        private IUnitOfWork _unitOfWork;

        public GetAllConfirmationQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Confirmation>> Handle(GetAllConfirmationsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_unitOfWork.ConfirmationRepository.GetAll());
        }
    }
}
