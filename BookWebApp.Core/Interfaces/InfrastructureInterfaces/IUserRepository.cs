using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.Base;

namespace BookWebApp.Core.Interfaces.InfrastructureInterfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
