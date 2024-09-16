using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces;
using BookWebApp.Infrastructure.Repositories.Base;

namespace BookWebApp.Infrastructure.Repositories
{
    public class LibrarianRepository : Repository<Librarian>, ILibrarianRepository
    {
        public LibrarianRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
