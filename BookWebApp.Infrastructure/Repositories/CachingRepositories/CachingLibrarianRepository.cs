using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces;
using BookWebApp.Infrastructure.Repositories.Base;

namespace BookWebApp.Infrastructure.Repositories.CachingRepositories
{
    public class CachingLibrarianRepository : Repository<Librarian>, ILibrarianRepository
    {
        public CachingLibrarianRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
