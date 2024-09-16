namespace BookWebApp.Core.Domain
{
    public class Librarian
    {
        public Guid LibrarianId { get; set; }
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public IEnumerable<Confirmation>? Confirmations { get; set; }
    }
}
