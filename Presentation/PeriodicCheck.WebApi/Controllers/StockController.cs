using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.StockCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.StockHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.StockQuery;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly CreateStockCommandHandler _createStockCommandHandler;
        private readonly GetStockByIdQueryHandler _getStockByIdQueryHandler;
        private readonly GetStockQueryHandler _getStockQueryHandler;
        private readonly RemoveStockCommandHandler _removeStockCommandHandler;
        private readonly UpdateStockCommandHandler _updateStockCommandHandler;

        public StockController(CreateStockCommandHandler createStockCommandHandler, GetStockByIdQueryHandler getStockByIdQueryHandler, GetStockQueryHandler getStockQueryHandler, RemoveStockCommandHandler removeStockCommandHandler, UpdateStockCommandHandler updateStockCommandHandler)
        {
            _createStockCommandHandler = createStockCommandHandler;
            _getStockByIdQueryHandler = getStockByIdQueryHandler;
            _getStockQueryHandler = getStockQueryHandler;
            _removeStockCommandHandler = removeStockCommandHandler;
            _updateStockCommandHandler = updateStockCommandHandler;
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
            await _createStockCommandHandler.Handle(command);
            return Ok("Stok Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveStock(int id)
        {
            await _removeStockCommandHandler.Handle(new RemoveStockCommand(id));
            return Ok("Stok Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStock(UpdateStockCommand command)
        {
            await _updateStockCommandHandler.Handle(command);
            return Ok("Stok Güncellendi");
        }
    }
}
