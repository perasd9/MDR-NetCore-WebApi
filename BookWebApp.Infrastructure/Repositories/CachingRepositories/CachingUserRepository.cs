using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces;
using BookWebApp.Infrastructure.Repositories.Base;

namespace BookWebApp.Infrastructure.Repositories.CachingRepositories
{
    public class CachingUserRepository : Repository<User>, IUserRepository
    {
        public CachingUserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
