using BookWebApp.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookWebApp.Infrastructure.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.BookId).ValueGeneratedOnAdd();

            builder.HasMany(b => b.Confirmations).WithOne(c => c.Book);

            builder.Property(b => b.BookType).HasConversion<string>().HasColumnType("nvarchar(255)");

            var bookTypes = Enum.GetValues(typeof(TypeOfBook)).Cast<TypeOfBook>().Select(t => t.ToString()).ToArray();

            builder.ToTable(b => b.HasCheckConstraint("Book_TypeOfBook_Enum_Constraint", $"BookType IN ({string.Join(",", bookTypes.Select(t => $"'{t}'"))})"));
        }
    }
}
