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
            values.Selected_Fault = command.Selected_Fault;
            values.Report_Date = command.Report_Date;
            values.Report_Person = command.Report_Person;
            values.Solution_Date = command.Solution_Date;
            values.Solution_Person = command.Solution_Person;
            values.Case = command.Case;
            values.Fault_Description = command.Fault_Description;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
