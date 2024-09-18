using BookWebApp.Core.Domain;

namespace BookWebApp.Presentation.GraphQL.GraphQLMutations.BookInputs
{
    public class AddBookInput
    {
        public string? BookName { get; set; }
        public string? BookDescription { get; set; }
        public TypeOfBook BookType { get; set; }
        public int NumberOfCopies { get; set; }
        public string? Author { get; set; }
    }
}
