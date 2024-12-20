using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.CareCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.CareHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.CareQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareController : ControllerBase
    {
        private readonly CreateCareCommandHandler _createCareCommandHandler;
        private readonly GetCareByIdQueryHandler _getCareByIdQueryHandler;
        private readonly GetCareQueryHandler _getCareQueryHandler;
        private readonly UpdateCareCommandHandler _updateCareCommandHandler;
        private readonly RemoveCareCommandHandler _removeCareCommandHandler;
        public CareController(CreateCareCommandHandler createCareCommandHandler, GetCareByIdQueryHandler getCareByIdQueryHandler, GetCareQueryHandler getCareQueryHandler, UpdateCareCommandHandler updateCareCommandHandler, RemoveCareCommandHandler removeCareCommandHandler)
        {
            _createCareCommandHandler = createCareCommandHandler;
            _getCareByIdQueryHandler = getCareByIdQueryHandler;
            _getCareQueryHandler = getCareQueryHandler;
            _updateCareCommandHandler = updateCareCommandHandler;
            _removeCareCommandHandler = removeCareCommandHandler;
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
            await _createCareCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCare(int id)
        {
            await _removeCareCommandHandler.Handle(new RemoveCareCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCare(UpdateCareCommand command)
        {
            await _updateCareCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
    }
}
