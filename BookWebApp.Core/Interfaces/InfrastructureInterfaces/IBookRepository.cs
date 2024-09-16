using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.Base;

namespace BookWebApp.Core.Interfaces.InfrastructureInterfaces
{
    public interface IBookRepository : IRepository<Book>
    {
    }
}
