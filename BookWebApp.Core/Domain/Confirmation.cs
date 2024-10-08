﻿namespace BookWebApp.Core.Domain
{
    public class Confirmation
    {
        public Guid ConfirmationId { get; set; }
        public int ConfirmationNumber { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool Processed { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid LibrarianId { get; set; }
        public Librarian? Librarian { get; set; }
        public Guid BookId { get; set; }
        public Book? Book { get; set; }
    }
}
