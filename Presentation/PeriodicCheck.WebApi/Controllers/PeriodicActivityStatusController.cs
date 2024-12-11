using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Commands.PeriodicActivityStatusCommands;
using PeriodicCheck.Application.Features.CQRS.Handlers.PeriodicActivityStatusHandlers;
using PeriodicCheck.Application.Features.CQRS.Queries.PeriodicActivityStatusQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeriodicActivityStatusController : ControllerBase
    {
        private readonly CreatePeriodicActivityStatusCommandHandler _createCommandHandler;
        private readonly GetPeriodicActivityStatusByIdQueryHandler _getPeriodicActivityStatusByIdQueryHandler;
        private readonly GetPeriodicActivityStatusQueryHandler _getPeriodicActivityStatusQueryHandler;
        private readonly UpdatePeriodicActivityStatusCommandHandler _updateCommandHandler;
        private readonly RemovePeriodicActivityStatusCommandHandler _removeCommandHandler;

        public PeriodicActivityStatusController(CreatePeriodicActivityStatusCommandHandler createCommandHandler, GetPeriodicActivityStatusByIdQueryHandler getPeriodicActivityStatusByIdQueryHandler, GetPeriodicActivityStatusQueryHandler getPeriodicActivityStatusQueryHandler, UpdatePeriodicActivityStatusCommandHandler updateCommandHandler, RemovePeriodicActivityStatusCommandHandler removeCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getPeriodicActivityStatusByIdQueryHandler = getPeriodicActivityStatusByIdQueryHandler;
            _getPeriodicActivityStatusQueryHandler = getPeriodicActivityStatusQueryHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> PeriodicActivityStatusList()
        {
            var values = await _getPeriodicActivityStatusQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPeriodicActivityStatus(int id)
        {
            var value = await _getPeriodicActivityStatusByIdQueryHandler.Handle(new PeriodicActivityStatusByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePeriodicActivityStatus(CreatePeriodicActivityStatusCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Hareket Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemovePeriodicActivityStatus(int id)
        {
            await _removeCommandHandler.Handle(new RemovePeriodicActivityStatusCommand(id));
            return Ok("Hareket Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePeriodicActivityStatus(UpdatePeriodicActivityStatusCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Hareket Bilgisi Güncellendi");
        }
    }
}
