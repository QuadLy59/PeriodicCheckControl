using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeriodicCheck.Application.Features.CQRS.Command.AuthorityCommand;
using PeriodicCheck.Application.Features.CQRS.Handler.AuthorityHandler;
using PeriodicCheck.Application.Features.CQRS.Queries.AuthorityQueries;

namespace PeriodicCheck.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorityController : ControllerBase
    {
        private readonly CreateAuthorityCommandHandler _createAuthorityCommandHandler;
        private readonly GetAuthorityByIdQueryHandler _getAuthorityByIdQueryHandler;
        private readonly GetAuthorityQueryHandler _getAuthorityQueryHandler;
        private readonly UpdateAuthorityCommandHandler _updateAuthorityCommandHandler;
        private readonly RemoveAuthorityCommandHandler _removeAuthorityCommandHandler;
        public AuthorityController(CreateAuthorityCommandHandler createAuthorityCommandHandler, GetAuthorityByIdQueryHandler getAuthorityByIdQueryHandler, GetAuthorityQueryHandler getAuthorityQueryHandler, UpdateAuthorityCommandHandler updateAuthorityCommandHandler, RemoveAuthorityCommandHandler removeAuthorityCommandHandler)
        {
            _createAuthorityCommandHandler = createAuthorityCommandHandler;
            _getAuthorityByIdQueryHandler = getAuthorityByIdQueryHandler;
            _getAuthorityQueryHandler = getAuthorityQueryHandler;
            _updateAuthorityCommandHandler = updateAuthorityCommandHandler;
            _removeAuthorityCommandHandler = removeAuthorityCommandHandler;
        }

        
        [HttpGet]
        public async Task <IActionResult> AuthorityList()
        {
            var values = await _getAuthorityQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthority(int id)
        {
            var value = await _getAuthorityByIdQueryHandler.Handle(new GetAuthorityByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAuthority(CreateAuthorityCommand command)
        {
            await _createAuthorityCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveAuthority(int id)
        {
            await _removeAuthorityCommandHandler.Handle(new RemoveAuthorityCommand(id));
            return Ok("Bilgi Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthority(UpdateAuthorityCommand command)
        {
            await _updateAuthorityCommandHandler.Handle(command);
            return Ok("Bilgi Eklendi");
        }

    }
}
