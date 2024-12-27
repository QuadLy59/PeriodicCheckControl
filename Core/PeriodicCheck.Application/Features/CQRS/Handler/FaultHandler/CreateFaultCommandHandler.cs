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
                Selected_Fault = command.Selected_Fault,
                Report_Date = command.Report_Date,
                Report_Person = command.Report_Person,
                Solution_Date = command.Solution_Date,
                Solution_Person = command.Solution_Person,
                Case = command.Case,
                Fault_Description = command.Fault_Description,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active,
            });
        }
    }
}
