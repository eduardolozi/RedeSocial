using Infra.Dtos;
using Infra.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly TokenService _tokenService;
        public LoginController(TokenService tokenService) 
        {
            _tokenService = tokenService;    
        }

        [HttpPost]
        public ActionResult Login([FromBody] UsuarioDto usuarioDto)
        {
            var token = _tokenService.GerarToken(usuarioDto);
            return (token == String.Empty) ? Unauthorized() : Ok(token);
        }
    }
}
