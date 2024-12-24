using PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand;
using PeriodicCheck.Application.Features.CQRS.Command.RoleCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultDetailHandler
{
    public class RemoveFaultDetailCommandHandler
    {
        private readonly IRepository<FaultDetail> _repository;

        public RemoveFaultDetailCommandHandler(IRepository<FaultDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFaultDetailCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
