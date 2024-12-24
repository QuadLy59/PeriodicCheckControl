using PeriodicCheck.Application.Features.CQRS.Command.MaterialCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.MaterialHandler
{
    public class CreateMaterialCommandHandler
    {
        private readonly IRepository<Material> _repository;

        public CreateMaterialCommandHandler(IRepository<Material> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMaterialCommand command)
        {
            await _repository.CreateAsync(new Material
            {
                Material_Name = command.Material_Name,
                CareId = command.CareId,
                EquipmentId = command.EquipmentId,
                Ins_user = command.Ins_user,
                Ins_date = command.Ins_date,
                Is_active = command.Is_active
            });
        }
    }
}
