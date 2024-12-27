using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.FaultNameCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.FaultNameHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.FaultNameQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FaultNameController : ControllerBase
    {
        private readonly CreateFaultNameCommandHandler _createFaultNameCommandHandler;
        private readonly GetFaultNameByIdQueryHandler _getFaultNameByIdQueryHandler;
        private readonly GetFaultNameQueryHandler _getFaultNameQueryHandler;
        private readonly UpdateFaultNameCommandHandler _updateFaultNameCommandHandler;
        private readonly RemoveFaultNameCommandHandler _removeFaultNameCommandHandler;
        public FaultNameController(CreateFaultNameCommandHandler createFaultNameCommandHandler, GetFaultNameByIdQueryHandler getFaultNameByIdQueryHandler, GetFaultNameQueryHandler getFaultNameQueryHandler, UpdateFaultNameCommandHandler updateFaultNameCommandHandler, RemoveFaultNameCommandHandler removeFaultNameCommandHandler)
        {
            _createFaultNameCommandHandler = createFaultNameCommandHandler;
            _getFaultNameByIdQueryHandler = getFaultNameByIdQueryHandler;
            _getFaultNameQueryHandler = getFaultNameQueryHandler;
            _updateFaultNameCommandHandler = updateFaultNameCommandHandler;
            _removeFaultNameCommandHandler = removeFaultNameCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> FaultNameList()
        {
            var values = await _getFaultNameQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFaultName(int id)
        {
            var value = await _getFaultNameByIdQueryHandler.Handle(new GetFaultNameByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateFaultName(CreateFaultNameCommand command)
        {
            await _createFaultNameCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFaultName(int id)
        {
            await _removeFaultNameCommandHandler.Handle(new RemoveFaultNameCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFaultName(UpdateFaultNameCommand command)
        {
            await _updateFaultNameCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
    }
}
