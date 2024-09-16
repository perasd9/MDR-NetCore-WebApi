namespace BookWebApp.Core.Interfaces.InfrastructureInterfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }
        public ILibrarianRepository LibrarianRepository { get; }
        public IBookRepository BookRepository { get; }
        public IConfirmationRepository ConfirmationRepository { get; }
        public Task SaveChangesAsync();
    }
}
