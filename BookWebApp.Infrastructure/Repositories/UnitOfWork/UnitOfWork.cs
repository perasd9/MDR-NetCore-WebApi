using BookWebApp.Core.Interfaces.InfrastructureInterfaces;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.UnitOfWork;

namespace BookWebApp.Infrastructure.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationContext _context;
        private Lazy<IUserRepository> _userRepository;
        private Lazy<ILibrarianRepository> _librarianRepository;
        private Lazy<IBookRepository> _bookRepository;
        private Lazy<IConfirmationRepository> _confirmationRepository;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context), true);
            _librarianRepository = new Lazy<ILibrarianRepository>(() => new LibrarianRepository(_context), true);
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(_context), true);
            _confirmationRepository = new Lazy<IConfirmationRepository>(() => new ConfirmationRepository(_context), true);
        }

        public IUserRepository UserRepository => _userRepository.Value;

        public ILibrarianRepository LibrarianRepository => _librarianRepository.Value;

        public IBookRepository BookRepository => _bookRepository.Value;

        public IConfirmationRepository ConfirmationRepository => _confirmationRepository.Value;


        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
