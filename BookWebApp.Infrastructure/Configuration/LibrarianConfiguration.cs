using BookWebApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWebApp.Infrastructure.Configuration
{
    public class LibrarianConfiguration : IEntityTypeConfiguration<Librarian>
    {
        public void Configure(EntityTypeBuilder<Librarian> builder)
        {
            builder.HasKey(l => l.LibrarianId);

            builder.Property(l => l.LibrarianId).ValueGeneratedOnAdd();

            builder.HasMany(l => l.Confirmations);
        }
    }
}
