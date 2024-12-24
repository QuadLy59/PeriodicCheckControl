using PeriodicCheck.Application.Features.CQRS.Command.MaterialCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.MaterialHandler
{
    public class UpdateMaterialCommandHandler
    {
        private readonly IRepository<Material> _repository;

        public UpdateMaterialCommandHandler(IRepository<Material> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMaterialCommand command)
        {
            var values = await _repository.GetByIdAsync(command.MaterialId);
            values.Material_Name = command.Material_Name;
            values.CareId = command.CareId;
            values.EquipmentId = command.EquipmentId;
            values.Updated_user = command.Updated_user;
            values.Updated_date = command.Updated_date;
            values.Is_active = command.Is_active;
            await _repository.UpdateAsync(values);
        }
    }
}
