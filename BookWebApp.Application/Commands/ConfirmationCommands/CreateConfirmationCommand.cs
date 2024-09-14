using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;

namespace BookWebApp.Application.Commands.ConfirmationCommands
{
    public class CreateConfirmationCommand : ICommand<Confirmation>
    {
        public Confirmation? Confirmation{ get; set; }
    }
}
