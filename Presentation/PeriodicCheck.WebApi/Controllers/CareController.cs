using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Commands.CareCommands;
using PeriodicCheck.Application.Features.CQRS.Handlers.CareHandlers;
using PeriodicCheck.Application.Features.CQRS.Queries.CareQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareController : ControllerBase
    {
        private readonly CreateCareCommandHandler _createCommandHandler;
        private readonly GetCareByIdQueryHandler _getCareByIdQueryHandler;
        private readonly GetCareQueryHandler _getCareQueryHandler;
        private readonly UpdateCareCommandHandler _updateCommandHandler;
        private readonly RemoveCareCommandHandler _removeCommandHandler;

        public CareController(CreateCareCommandHandler createCommandHandler, GetCareByIdQueryHandler getCareByIdQueryHandler, GetCareQueryHandler getCareQueryHandler, UpdateCareCommandHandler updateCommandHandler, RemoveCareCommandHandler removeCommandHandler)
        {
            _createCommandHandler = createCommandHandler;
            _getCareByIdQueryHandler = getCareByIdQueryHandler;
            _getCareQueryHandler = getCareQueryHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> CareList()
        {
            var values = await _getCareQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCare(int id)
        {
            var value = await _getCareByIdQueryHandler.Handle(new GetCareByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCare(CreateCareCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Bakım Bilgisi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCare(int id)
        {
            await _removeCommandHandler.Handle(new RemoveCareCommand(id));
            return Ok("Bakım Bilgisi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCare(UpdateCareCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Bakım Bilgisi Güncellendi");
        }
    }
}
