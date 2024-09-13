namespace BookWebApp.Core.Domain
{
    public class User
    {
        public Guid UserID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
    }
}
