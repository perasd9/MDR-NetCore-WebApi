namespace BookWebApp.Presentation.GraphQL.GraphQLMutations.ConfirmationInputs
{
    public class AddConfirmationInput
    {
        public int ConfirmationNumber { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool Processed { get; set; }
        public Guid UserId { get; set; }
        public Guid LibrarianId { get; set; }
        public Guid BookId { get; set; }
    }
}
