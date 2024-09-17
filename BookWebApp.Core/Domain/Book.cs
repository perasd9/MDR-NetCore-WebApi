namespace BookWebApp.Core.Domain
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookDescription { get; set; }
        public TypeOfBook BookType { get; set; }
        public int NumberOfCopies { get; set; }
        public string? Author { get; set; }
        public IEnumerable<Confirmation>? Confirmations { get; set; }
    }
}
