using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.EquipmentCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.EquipmentHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.EquipmentQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly CreateEquipmentCommandHandler _createEquipmentCommandHandler;
        private readonly GetEquipmentByIdQueryHandler _getEquipmentByIdQueryHandler;
        private readonly GetEquipmentQueryHandler _getEquipmentQueryHandler;
        private readonly RemoveEquipmentCommandHandler _removeEquipmentCommandHandler;
        private readonly UpdateEquipmentCommandHandler _updateEquipmentCommandHandler;

        public EquipmentController(CreateEquipmentCommandHandler createEquipmentCommandHandler, GetEquipmentByIdQueryHandler getEquipmentByIdQueryHandler, GetEquipmentQueryHandler getEquipmentQueryHandler, RemoveEquipmentCommandHandler removeEquipmentCommandHandler, UpdateEquipmentCommandHandler updateEquipmentCommandHandler)
        {
            _createEquipmentCommandHandler = createEquipmentCommandHandler;
            _getEquipmentByIdQueryHandler = getEquipmentByIdQueryHandler;
            _getEquipmentQueryHandler = getEquipmentQueryHandler;
            _removeEquipmentCommandHandler = removeEquipmentCommandHandler;
            _updateEquipmentCommandHandler = updateEquipmentCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> EquipmentList()
        {
            var values = await _getEquipmentQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEquipment(int id)
        {
            var value = await _getEquipmentByIdQueryHandler.Handle(new GetEquipmentByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEquipment(CreateEquipmentCommand command)
        {
            await _createEquipmentCommandHandler.Handle(command);
            return Ok("Rol Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveEquipment(int id)
        {
            await _removeEquipmentCommandHandler.Handle(new RemoveEquipmentCommand(id));
            return Ok("Rol Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEquipment(UpdateEquipmentCommand command)
        {
            await _updateEquipmentCommandHandler.Handle(command);
            return Ok("Rol Güncellendi");
        }
    }
}
