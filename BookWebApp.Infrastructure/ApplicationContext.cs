using BookWebApp.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace BookWebApp.Infrastructure
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Confirmation> Confirmations { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
