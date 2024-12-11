using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Commands.StockCommands;
using PeriodicCheck.Application.Features.CQRS.Handlers.StockHandlers;
using PeriodicCheck.Application.Features.CQRS.Queries.StockQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly CreateStockCommandHandler _createCommandHandler;
        private readonly GetStockByIdQueryHandler _getStockByIdQueryHandler;
        private readonly GetStockQueryHandler _getStockQueryHandler;
        private readonly UpdateStockCommandHandler _updateCommandHandler;
        private readonly RemoveStockCommandHandler _removeCommandHandler;

        public StockController(CreateStockCommandHandler createCommandHandler, GetStockByIdQueryHandler getStockByIdQueryHandler, GetStockQueryHandler getStockQueryHandler, UpdateStockCommandHandler updateCommandHandler, RemoveStockCommandHandler removeCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getStockByIdQueryHandler = getStockByIdQueryHandler;
            _getStockQueryHandler = getStockQueryHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> StockList()
        {
            var values = await _getStockQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStock(int id)
        {
            var value = await _getStockByIdQueryHandler.Handle(new GetStockByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateStock(CreateStockCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Stok Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveStock(int id)
        {
            await _removeCommandHandler.Handle(new RemoveStockCommand(id));
            return Ok("Stok Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStock(UpdateStockCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Stok Bilgisi Güncellendi");
        }
    }
}
