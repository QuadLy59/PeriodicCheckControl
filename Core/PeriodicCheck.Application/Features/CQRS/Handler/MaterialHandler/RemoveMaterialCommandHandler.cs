using PeriodicCheck.Application.Features.CQRS.Command.MaterialCommand;
using PeriodicCheck.Application.Features.CQRS.Command.RoleCommand;
using PeriodicCheck.Application.Interfaces;
using PeriodicCheck.Domain.Entities;
using System.Threading.Tasks;

namespace PeriodicCheck.Application.Features.CQRS.Handler.MaterialHandler
{
    public class RemoveMaterialCommandHandler
    {
        private readonly IRepository<Material> _repository;

        public RemoveMaterialCommandHandler(IRepository<Material> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMaterialCommand command)
        {
            var material = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(material);
        }
    }
}
