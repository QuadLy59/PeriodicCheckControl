using PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.FaultDetailHandler
{
    public class CreateFaultDetailCommandHandler
    {
        private readonly IRepository<FaultDetail> _repository;

        public CreateFaultDetailCommandHandler(IRepository<FaultDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFaultDetailCommand command)
        {
            await _repository.CreateAsync(new FaultDetail
            {
                EquipmentId = command.EquipmentId,
                CategoryId = command.CategoryId,
                FaultId = command.FaultId,
                Report_Date = command.Report_Date,
                Report_Person = command.Report_Person,
                Solution_Date = command.Solution_Date,
                Solution_Person = command.Solution_Person,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active,
            });
        }
    }
}
