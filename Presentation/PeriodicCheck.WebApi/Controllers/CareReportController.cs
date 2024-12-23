using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.CareReportCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.CareReportHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.CareReportQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CareReportController : ControllerBase
    {
        private readonly CreateCareReportCommandHandler _createCareReportCommandHandler;
        private readonly GetCareReportByIdQueryHandler _getCareReportByIdQueryHandler;
        private readonly GetCareReportQueryHandler _getCareReportQueryHandler;
        private readonly RemoveCareReportCommandHandler _removeCareReportCommandHandler;
        private readonly UpdateCareReportCommandHandler _updateCareReportCommandHandler;

        public CareReportController(CreateCareReportCommandHandler createCareReportCommandHandler, GetCareReportByIdQueryHandler getCareReportByIdQueryHandler, GetCareReportQueryHandler getCareReportQueryHandler, RemoveCareReportCommandHandler removeCareReportCommandHandler, UpdateCareReportCommandHandler updateCareReportCommandHandler)
        {
            _createCareReportCommandHandler = createCareReportCommandHandler;
            _getCareReportByIdQueryHandler = getCareReportByIdQueryHandler;
            _getCareReportQueryHandler = getCareReportQueryHandler;
            _removeCareReportCommandHandler = removeCareReportCommandHandler;
            _updateCareReportCommandHandler = updateCareReportCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> CareReportList()
        {
            var values = await _getCareReportQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCareReport(int id)
        {
            var value = await _getCareReportByIdQueryHandler.Handle(new GetCareReportByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCareReport(CreateCareReportCommand command)
        {
            await _createCareReportCommandHandler.Handle(command);
            return Ok("Rol Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCareReport(int id)
        {
            await _removeCareReportCommandHandler.Handle(new RemoveCareReportCommand(id));
            return Ok("Rol Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCareReport(UpdateCareReportCommand command)
        {
            await _updateCareReportCommandHandler.Handle(command);
            return Ok("Rol Güncellendi");
        }
    }
}
