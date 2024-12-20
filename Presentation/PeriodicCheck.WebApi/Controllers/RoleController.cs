using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SurveySystem.Application.Features.CQRS.Commands.RoleCommands;
using SurveySystem.Application.Features.CQRS.Handlers.RoleHandlers;
using SurveySystem.Application.Features.CQRS.Queries.RoleQueries;

namespace SurveySystem.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly CreateRoleCommandHandler _createRoleCommandHandler;
        private readonly GetRoleByIdQueryHandler _getRoleByIdQueryHandler;
        private readonly GetRoleQueryHandler _getRoleQueryHandler;
        private readonly RemoveRoleCommandHandler _removeRoleCommandHandler;
        private readonly UpdateRoleCommandHandler _updateRoleCommandHandler;

        public RoleController(CreateRoleCommandHandler createRoleCommandHandler, GetRoleByIdQueryHandler getRoleByIdQueryHandler, GetRoleQueryHandler getRoleQueryHandler, RemoveRoleCommandHandler removeRoleCommandHandler, UpdateRoleCommandHandler updateRoleCommandHandler)
        {
            _createRoleCommandHandler = createRoleCommandHandler;
            _getRoleByIdQueryHandler = getRoleByIdQueryHandler;
            _getRoleQueryHandler = getRoleQueryHandler;
            _removeRoleCommandHandler = removeRoleCommandHandler;
            _updateRoleCommandHandler = updateRoleCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> RoleList()
        {
            var values = await _getRoleQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(int id)
        {
            var value = await _getRoleByIdQueryHandler.Handle(new GetRoleByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleCommand command)
        {
            await _createRoleCommandHandler.Handle(command);
            return Ok("Rol Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveRole(int id)
        {
            await _removeRoleCommandHandler.Handle(new RemoveRoleCommand(id));
            return Ok("Rol Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRole(UpdateRoleCommand command)
        {
            await _updateRoleCommandHandler.Handle(command);
            return Ok("Rol Güncellendi");
        }
    }
}
