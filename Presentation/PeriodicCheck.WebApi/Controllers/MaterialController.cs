using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.MaterialCommand;
using PeriodicCheck.Application.Features.CQRS.Command.RoleCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.MaterialHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.MaterialQueries;
using PeriodicCheck.Application.Features.CQRS.Queries.RoleQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly CreateMaterialCommandHandler _createMaterialCommandHandler;
        private readonly GetMaterialByIdQueryHandler _getMaterialByIdQueryHandler;
        private readonly GetMaterialQueryHandler _getMaterialQueryHandler;
        private readonly RemoveMaterialCommandHandler _removeMaterialCommandHandler;
        private readonly UpdateMaterialCommandHandler _updateMaterialCommandHandler;

        public MaterialController(CreateMaterialCommandHandler createMaterialCommandHandler, GetMaterialByIdQueryHandler getMaterialByIdQueryHandler, GetMaterialQueryHandler getMaterialQueryHandler, RemoveMaterialCommandHandler removeMaterialCommandHandler, UpdateMaterialCommandHandler updateMaterialCommandHandler)
        {
            _createMaterialCommandHandler = createMaterialCommandHandler;
            _getMaterialByIdQueryHandler = getMaterialByIdQueryHandler;
            _getMaterialQueryHandler = getMaterialQueryHandler;
            _removeMaterialCommandHandler = removeMaterialCommandHandler;
            _updateMaterialCommandHandler = updateMaterialCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> MaterialList()
        {
            var values = await _getMaterialQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMaterial(int id)
        {
            var value = await _getMaterialByIdQueryHandler.Handle(new GetMaterialByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMaterial(CreateMaterialCommand command)
        {
            await _createMaterialCommandHandler.Handle(command);
            return Ok("Malzeme Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveMaterial(int id)
        {
            await _removeMaterialCommandHandler.Handle(new RemoveMaterialCommand(id));
            return Ok("Malzeme Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMaterial(UpdateMaterialCommand command)
        {
            await _updateMaterialCommandHandler.Handle(command);
            return Ok("Malzeme Güncellendi");
        }
    }
}
