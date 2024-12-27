using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.CareMaterialCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.CareMaterialHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.CareMaterialQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CareMaterialController : ControllerBase
    {
        private readonly CreateCareMaterialCommandHandler _createCareMaterialCommandHandler;
        private readonly GetCareMaterialByIdQueryHandler _getCareMaterialByIdQueryHandler;
        private readonly GetCareMaterialQueryHandler _getCareMaterialQueryHandler;
        private readonly UpdateCareMaterialCommandHandler _updateCareMaterialCommandHandler;
        private readonly RemoveCareMaterialCommandHandler _removeCareMaterialCommandHandler;
        public CareMaterialController(CreateCareMaterialCommandHandler createCareMaterialCommandHandler, GetCareMaterialByIdQueryHandler getCareMaterialByIdQueryHandler, GetCareMaterialQueryHandler getCareMaterialQueryHandler, UpdateCareMaterialCommandHandler updateCareMaterialCommandHandler, RemoveCareMaterialCommandHandler removeCareMaterialCommandHandler)
        {
            _createCareMaterialCommandHandler = createCareMaterialCommandHandler;
            _getCareMaterialByIdQueryHandler = getCareMaterialByIdQueryHandler;
            _getCareMaterialQueryHandler = getCareMaterialQueryHandler;
            _updateCareMaterialCommandHandler = updateCareMaterialCommandHandler;
            _removeCareMaterialCommandHandler = removeCareMaterialCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> CareMaterialList()
        {
            var values = await _getCareMaterialQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCareMaterial(int id)
        {
            var value = await _getCareMaterialByIdQueryHandler.Handle(new GetCareMaterialByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCareMaterial(CreateCareMaterialCommand command)
        {
            await _createCareMaterialCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCareMaterial(int id)
        {
            await _removeCareMaterialCommandHandler.Handle(new RemoveCareMaterialCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCareMaterial(UpdateCareMaterialCommand command)
        {
            await _updateCareMaterialCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
    }
}
