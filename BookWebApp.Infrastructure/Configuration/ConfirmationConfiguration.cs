using BookWebApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWebApp.Infrastructure.Configuration
{
    public class ConfirmationConfiguration : IEntityTypeConfiguration<Confirmation>
    {
        public void Configure(EntityTypeBuilder<Confirmation> builder)
        {
            builder.HasKey(c => c.ConfirmationId);

            builder.Property(c => c.ConfirmationId).ValueGeneratedOnAdd();

            builder.HasOne(c => c.User).WithMany(u => u.Confirmations);
            builder.HasOne(c => c.Librarian).WithMany(u => u.Confirmations);
            builder.HasOne(c => c.Book).WithMany(b => b.Confirmations);
        }
    }
}
