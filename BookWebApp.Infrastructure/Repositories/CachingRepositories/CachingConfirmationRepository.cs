using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces;
using BookWebApp.Infrastructure.Repositories.Base;

namespace BookWebApp.Infrastructure.Repositories.CachingRepositories
{
    public class CachingConfirmationRepository : Repository<Confirmation>, IConfirmationRepository
    {
        public CachingConfirmationRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
