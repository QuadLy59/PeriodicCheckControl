using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Commands.WarehouseCommands;
using PeriodicCheck.Application.Features.CQRS.Handlers.WarehouseHandlers;
using PeriodicCheck.Application.Features.CQRS.Queries.WarehouseQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly CreateWarehouseCommandHandler _createCommandHandler;
        private readonly GetWarehouseByIdQueryHandler _getWarehouseByIdQueryHandler;
        private readonly GetWarehouseQueryHandler _getWarehouseQueryHandler;
        private readonly UpdateWarehouseCommandHandler _updateCommandHandler;
        private readonly RemoveWarehouseCommandHandler _removeCommandHandler;

        public WarehouseController(CreateWarehouseCommandHandler createCommandHandler, GetWarehouseByIdQueryHandler getWarehouseByIdQueryHandler, GetWarehouseQueryHandler getWarehouseQueryHandler, UpdateWarehouseCommandHandler updateCommandHandler, RemoveWarehouseCommandHandler removeCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getWarehouseByIdQueryHandler = getWarehouseByIdQueryHandler;
            _getWarehouseQueryHandler = getWarehouseQueryHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> WarehouseList()
        {
            var values = await _getWarehouseQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWarehouse(int id)
        {
            var value = await _getWarehouseByIdQueryHandler.Handle(new GetWarehouseByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWarehouse(CreateWarehouseCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Depo Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveWarehouse(int id)
        {
            await _removeCommandHandler.Handle(new RemoveWarehouseCommand(id));
            return Ok("Depo Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWarehouse(UpdateWarehouseCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Depo Bilgisi Güncellendi");
        }
    }
}
