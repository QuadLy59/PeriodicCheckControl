using PeriodicCheck.Application.Features.CQRS.Command.FaultCommand;
using PeriodicCheck.Application.Features.CQRS.Command.RoleCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultHandler
{
    public class RemoveFaultCommandHandler
    {
        private readonly IRepository<Fault> _repository;

        public RemoveFaultCommandHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFaultCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
