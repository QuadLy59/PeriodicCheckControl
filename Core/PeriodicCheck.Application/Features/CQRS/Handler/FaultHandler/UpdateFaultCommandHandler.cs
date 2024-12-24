using PeriodicCheck.Application.Features.CQRS.Command.FaultCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultHandler
{
    public class UpdateFaultCommandHandler
    {
        private readonly IRepository<Fault> _repository;

        public UpdateFaultCommandHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateFaultCommand command)
        {
            var values = await _repository.GetByIdAsync(command.FaultId);
            values.Fault_Name = command.Fault_Name;
            values.Selected_Fault = command.Selected_Fault;
            values.Case = command.Case;
            values.EquipmentId = command.EquipmentId;
            values.Fault_Description = command.Fault_Description;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
