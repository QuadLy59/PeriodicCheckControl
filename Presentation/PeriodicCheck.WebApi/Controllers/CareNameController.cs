using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.CareNameCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.CareNameHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.CareNameQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CareNameController : ControllerBase
    {
        private readonly CreateCareNameCommandHandler _createCareNameCommandHandler;
        private readonly GetCareNameByIdQueryHandler _getCareNameByIdQueryHandler;
        private readonly GetCareNameQueryHandler _getCareNameQueryHandler;
        private readonly UpdateCareNameCommandHandler _updateCareNameCommandHandler;
        private readonly RemoveCareNameCommandHandler _removeCareNameCommandHandler;
        public CareNameController(CreateCareNameCommandHandler createCareNameCommandHandler, GetCareNameByIdQueryHandler getCareNameByIdQueryHandler, GetCareNameQueryHandler getCareNameQueryHandler, UpdateCareNameCommandHandler updateCareNameCommandHandler, RemoveCareNameCommandHandler removeCareNameCommandHandler)
        {
            _createCareNameCommandHandler = createCareNameCommandHandler;
            _getCareNameByIdQueryHandler = getCareNameByIdQueryHandler;
            _getCareNameQueryHandler = getCareNameQueryHandler;
            _updateCareNameCommandHandler = updateCareNameCommandHandler;
            _removeCareNameCommandHandler = removeCareNameCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> CareNameList()
        {
            var values = await _getCareNameQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCareName(int id)
        {
            var value = await _getCareNameByIdQueryHandler.Handle(new GetCareNameByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCareName(CreateCareNameCommand command)
        {
            await _createCareNameCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCareName(int id)
        {
            await _removeCareNameCommandHandler.Handle(new RemoveCareNameCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCareName(UpdateCareNameCommand command)
        {
            await _updateCareNameCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
    }
}
