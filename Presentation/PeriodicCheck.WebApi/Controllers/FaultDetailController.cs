using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.FaultDetailCommand;
using PeriodicCheck.Application.Features.CQRS.Command.RoleCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.FaultDetailHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FaultDetailController : ControllerBase
    {
        private readonly CreateFaultDetailCommandHandler _createFaultDetailCommandHandler;
        private readonly GetFaultDetailByIdQueryHandler _getFaultDetailByIdQueryHandler;
        private readonly GetFaultDetailQueryHandler _getFaultDetailQueryHandler;
        private readonly RemoveFaultDetailCommandHandler _removeFaultDetailCommandHandler;
        private readonly UpdateFaultDetailCommandHandler _updateFaultDetailCommandHandler;

        public FaultDetailController(CreateFaultDetailCommandHandler createFaultDetailCommandHandler, GetFaultDetailByIdQueryHandler getFaultDetailByIdQueryHandler, GetFaultDetailQueryHandler getFaultDetailQueryHandler, RemoveFaultDetailCommandHandler removeFaultDetailCommandHandler, UpdateFaultDetailCommandHandler updateFaultDetailCommandHandler)
        {
            _createFaultDetailCommandHandler = createFaultDetailCommandHandler;
            _getFaultDetailByIdQueryHandler = getFaultDetailByIdQueryHandler;
            _getFaultDetailQueryHandler = getFaultDetailQueryHandler;
            _removeFaultDetailCommandHandler = removeFaultDetailCommandHandler;
            _updateFaultDetailCommandHandler = updateFaultDetailCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> FaultDetailList()
        {
            var values = await _getFaultDetailQueryHandler.Handle();
            return Ok(values);
        }

   
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFaultDetail(int id)
        {
            var value = await _getFaultDetailByIdQueryHandler.Handle(new GetFaultDetailByIdQuery(id));
            return Ok(value);
        }


        [HttpPost]
        public async Task<IActionResult> CreateFaultDetail(CreateFaultDetailCommand command)
        {
            await _createFaultDetailCommandHandler.Handle(command);
            return Ok("Fault Detail Eklendi");
        }


        [HttpDelete]
        public async Task<IActionResult> RemoveFaultDetail(int id)
        {
            await _removeFaultDetailCommandHandler.Handle(new RemoveFaultDetailCommand(id));
            return Ok("Fault Detail Silindi");
        }

   
        [HttpPut]
        public async Task<IActionResult> UpdateFaultDetail(UpdateFaultDetailCommand command)
        {
            await _updateFaultDetailCommandHandler.Handle(command);
            return Ok("Fault Detail Güncellendi");
        }
    }
}
