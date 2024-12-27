using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.RoleAuthorityCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.RoleAuthorityHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.RoleAuthorityQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleAuthorityController : ControllerBase
    {
        private readonly CreateRoleAuthorityCommandHandler _createRoleAuthorityCommandHandler;
        private readonly GetRoleAuthorityByIdQueryHandler _getRoleAuthorityByIdQueryHandler;
        private readonly GetRoleAuthorityQueryHandler _getRoleAuthorityQueryHandler;
        private readonly UpdateRoleAuthorityCommandHandler _updateRoleAuthorityCommandHandler;
        private readonly RemoveRoleAuthorityCommandHandler _removeRoleAuthorityCommandHandler;
        public RoleAuthorityController(CreateRoleAuthorityCommandHandler createRoleAuthorityCommandHandler, GetRoleAuthorityByIdQueryHandler getRoleAuthorityByIdQueryHandler, GetRoleAuthorityQueryHandler getRoleAuthorityQueryHandler, UpdateRoleAuthorityCommandHandler updateRoleAuthorityCommandHandler, RemoveRoleAuthorityCommandHandler removeRoleAuthorityCommandHandler)
        {
            _createRoleAuthorityCommandHandler = createRoleAuthorityCommandHandler;
            _getRoleAuthorityByIdQueryHandler = getRoleAuthorityByIdQueryHandler;
            _getRoleAuthorityQueryHandler = getRoleAuthorityQueryHandler;
            _updateRoleAuthorityCommandHandler = updateRoleAuthorityCommandHandler;
            _removeRoleAuthorityCommandHandler = removeRoleAuthorityCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> RoleAuthorityList()
        {
            var values = await _getRoleAuthorityQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleAuthority(int id)
        {
            var value = await _getRoleAuthorityByIdQueryHandler.Handle(new GetRoleAuthorityByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoleAuthority(CreateRoleAuthorityCommand command)
        {
            await _createRoleAuthorityCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveRoleAuthority(int id)
        {
            await _removeRoleAuthorityCommandHandler.Handle(new RemoveRoleAuthorityCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRoleAuthority(UpdateRoleAuthorityCommand command)
        {
            await _updateRoleAuthorityCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
    }
}
