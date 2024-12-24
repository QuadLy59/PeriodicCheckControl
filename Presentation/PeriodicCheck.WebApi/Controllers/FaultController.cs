using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.FaultCommand;
using PeriodicCheck.Application.Features.CQRS.Command.RoleCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.FaultHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FaultController : ControllerBase
    {
        private readonly CreateFaultCommandHandler _createFaultCommandHandler;
        private readonly GetFaultByIdQueryHandler _getFaultByIdQueryHandler;
        private readonly GetFaultQueryHandler _getFaultQueryHandler;
        private readonly RemoveFaultCommandHandler _removeFaultCommandHandler;
        private readonly UpdateFaultCommandHandler _updateFaultCommandHandler;

        public FaultController(CreateFaultCommandHandler createFaultCommandHandler, GetFaultByIdQueryHandler getFaultByIdQueryHandler, GetFaultQueryHandler getFaultQueryHandler, RemoveFaultCommandHandler removeFaultCommandHandler, UpdateFaultCommandHandler updateFaultCommandHandler)
        {
            _createFaultCommandHandler = createFaultCommandHandler;
            _getFaultByIdQueryHandler = getFaultByIdQueryHandler;
            _getFaultQueryHandler = getFaultQueryHandler;
            _removeFaultCommandHandler = removeFaultCommandHandler;
            _updateFaultCommandHandler = updateFaultCommandHandler;
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
            await _createFaultCommandHandler.Handle(command);
            return Ok("Hata Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFault(int id)
        {
            await _removeFaultCommandHandler.Handle(new RemoveFaultCommand(id));
            return Ok("Hata Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFault(UpdateFaultCommand command)
        {
            await _updateFaultCommandHandler.Handle(command);
            return Ok("Hata Güncellendi");
        }
    }
}
