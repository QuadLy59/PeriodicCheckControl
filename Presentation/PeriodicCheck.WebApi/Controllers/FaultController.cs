using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Commands.FaultCommands;
using PeriodicCheck.Application.Features.CQRS.Handlers.FaultHandlers;
using PeriodicCheck.Application.Features.CQRS.Queries.FaultQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaultController : ControllerBase
    {
        private readonly CreateFaultCommandHandler _createCommandHandler;
        private readonly GetFaultByIdQueryHandler _getFaultByIdQueryHandler;
        private readonly GetFaultQueryHandler _getFaultQueryHandler;
        private readonly UpdateFaultCommandHandler _updateCommandHandler;
        private readonly RemoveFaultCommandHandler _removeCommandHandler;

        public FaultController(CreateFaultCommandHandler createCommandHandler, GetFaultByIdQueryHandler getFaultByIdQueryHandler, GetFaultQueryHandler getFaultQueryHandler, UpdateFaultCommandHandler updateCommandHandler, RemoveFaultCommandHandler removeCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getFaultByIdQueryHandler = getFaultByIdQueryHandler;
            _getFaultQueryHandler = getFaultQueryHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> FaultList()
        {
            var values = await _getFaultQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFault(int id)
        {
            var value = await _getFaultByIdQueryHandler.Handle(new GetFaultByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFault(CreateFaultCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Arıza Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFault(int id)
        {
            await _removeCommandHandler.Handle(new RemoveFaultCommand(id));
            return Ok("Arıza Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFault(UpdateFaultCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Arıza Bilgisi Güncellendi");
        }
    }
}
