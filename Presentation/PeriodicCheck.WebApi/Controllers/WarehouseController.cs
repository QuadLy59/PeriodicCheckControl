using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.WarehouseCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.WarehouseHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.AuthorityQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly CreateWarehouseCommandHandler _createWarehouseCommandHandler;
        private readonly GetWarehouseByIdQueryHandler _getWarehouseByIdQueryHandler;
        private readonly GetWarehouseQueryHandler _getWarehouseQueryHandler;
        private readonly UpdateWarehouseCommandHandler _updateWarehouseCommandHandler;
        private readonly RemoveWarehouseCommandHandler _removeWarehouseCommandHandler;

        public WarehouseController(
            CreateWarehouseCommandHandler createWarehouseCommandHandler,
            GetWarehouseByIdQueryHandler getWarehouseByIdQueryHandler,
            GetWarehouseQueryHandler getWarehouseQueryHandler,
            UpdateWarehouseCommandHandler updateWarehouseCommandHandler,
            RemoveWarehouseCommandHandler removeWarehouseCommandHandler)
        {
            _createWarehouseCommandHandler = createWarehouseCommandHandler;
            _getWarehouseByIdQueryHandler = getWarehouseByIdQueryHandler;
            _getWarehouseQueryHandler = getWarehouseQueryHandler;
            _updateWarehouseCommandHandler = updateWarehouseCommandHandler;
            _removeWarehouseCommandHandler = removeWarehouseCommandHandler;
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
            await _createWarehouseCommandHandler.Handle(command);
            return Ok("Depo Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveWarehouse(int id)
        {
            await _removeWarehouseCommandHandler.Handle(new RemoveWarehouseCommand(id));
            return Ok("Depo Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWarehouse(UpdateWarehouseCommand command)
        {
            await _updateWarehouseCommandHandler.Handle(command);
            return Ok("Depo Güncellendi");
        }
    }
}
