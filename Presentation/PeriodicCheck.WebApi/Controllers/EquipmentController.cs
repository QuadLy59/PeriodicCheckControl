using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Commands.EquipmentCommands;
using PeriodicCheck.Application.Features.CQRS.Handlers.EquipmentHandlers;
using PeriodicCheck.Application.Features.CQRS.Queries.EquipmentQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly CreateEquipmentCommandHandler _createCommandHandler;
        private readonly GetEquipmentByIdQueryHandler _getEquipmentByIdQueryHandler;
        private readonly GetEquipmentQueryHandler _getEquipmentQueryHandler;
        private readonly UpdateEquipmentCommandHandler _updateCommandHandler;
        private readonly RemoveEquipmentCommandHandler _removeCommandHandler;

        public EquipmentController(CreateEquipmentCommandHandler createCommandHandler, GetEquipmentByIdQueryHandler getEquipmentByIdQueryHandler, GetEquipmentQueryHandler getEquipmentQueryHandler, UpdateEquipmentCommandHandler updateCommandHandler, RemoveEquipmentCommandHandler removeCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getEquipmentByIdQueryHandler = getEquipmentByIdQueryHandler;
            _getEquipmentQueryHandler = getEquipmentQueryHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
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
            await _createCommandHandler.Handle(command);
            return Ok("Ekipman Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveEquipment(int id)
        {
            await _removeCommandHandler.Handle(new RemoveEquipmentCommand(id));
            return Ok("Ekipman Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEquipment(UpdateEquipmentCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Ekipman Bilgisi Güncellendi");
        }
    }
}
