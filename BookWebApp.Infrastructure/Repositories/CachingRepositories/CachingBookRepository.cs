using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces;
using BookWebApp.Infrastructure.Repositories.Base;

namespace BookWebApp.Infrastructure.Repositories.CachingRepositories
{
    public class CachingBookRepository : Repository<Book>, IBookRepository
    {
        public CachingBookRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
