using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.CareDetailCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.CareDetailHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.CareDetailQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CareDetailController : ControllerBase
    {
        private readonly CreateCareDetailCommandHandler _createCareDetailCommandHandler;
        private readonly GetCareDetailByIdQueryHandler _getCareDetailByIdQueryHandler;
        private readonly GetCareDetailQueryHandler _getCareDetailQueryHandler;
        private readonly RemoveCareDetailCommandHandler _removeCareDetailCommandHandler;
        private readonly UpdateCareDetailCommandHandler _updateCareDetailCommandHandler;

        public CareDetailController(CreateCareDetailCommandHandler createCareDetailCommandHandler, GetCareDetailByIdQueryHandler getCareDetailByIdQueryHandler, GetCareDetailQueryHandler getCareDetailQueryHandler, RemoveCareDetailCommandHandler removeCareDetailCommandHandler, UpdateCareDetailCommandHandler updateCareDetailCommandHandler)
        {
            _createCareDetailCommandHandler = createCareDetailCommandHandler;
            _getCareDetailByIdQueryHandler = getCareDetailByIdQueryHandler;
            _getCareDetailQueryHandler = getCareDetailQueryHandler;
            _removeCareDetailCommandHandler = removeCareDetailCommandHandler;
            _updateCareDetailCommandHandler = updateCareDetailCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CareDetailList()
        {
            var values = await _getCareDetailQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCareDetail(int id)
        {
            var value = await _getCareDetailByIdQueryHandler.Handle(new GetCareDetailByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCareDetail(CreateCareDetailCommand command)
        {
            await _createCareDetailCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCareDetail(int id)
        {
            await _removeCareDetailCommandHandler.Handle(new RemoveCareDetailCommand(id));
            return Ok("Bilgi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCareDetail(UpdateCareDetailCommand command)
        {
            await _updateCareDetailCommandHandler.Handle(command);
            return Ok("Bilgi Güncellendi");
        }
    }
}
