using PeriodicCheck.Application.Features.CQRS.Command.FaultCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultHandler
{
    public class CreateFaultCommandHandler
    {
        private readonly IRepository<Fault> _repository;

        public CreateFaultCommandHandler(IRepository<Fault> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFaultCommand command)
        {
            await _repository.CreateAsync(new Fault
            {
                Fault_Name = command.Fault_Name,
                Selected_Fault = command.Selected_Fault,
                Case = command.Case,
                EquipmentId = command.EquipmentId,
                Fault_Description = command.Fault_Description,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active,
            });
        }
    }
}
