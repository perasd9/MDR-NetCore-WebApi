using BookWebApp.Application.Commands.ConfirmationCommands;
using BookWebApp.Core.Domain;
using BookWebApp.Core.Interfaces.ApplicationInterfaces;
using BookWebApp.Core.Interfaces.InfrastructureInterfaces.UnitOfWork;

namespace BookWebApp.Application.Handlers.ConfirmationCommandsHandlers
{
    public class CreateConfirmationCommandHandler : ICommandHandler<CreateConfirmationCommand, Confirmation>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateConfirmationCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Confirmation> Handle(CreateConfirmationCommand request, CancellationToken cancellationToken)
        {
            await _unitOfWork.ConfirmationRepository.Save(request.Confirmation!);
            await _unitOfWork.SaveChangesAsync();

            return request.Confirmation!;
        }
    }
}
