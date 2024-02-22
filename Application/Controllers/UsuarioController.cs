using Dominio.IRepositorios;
using Dominio.Modelos;
using Infra.Raven.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _repositorio;
        public UsuarioController(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> ObterTodos([FromQuery] string? userName)
        {
            try
            {
                var usuarios = _repositorio.ObterTodos(userName);
                return Ok(usuarios);
            } catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Usuario usuario)
        {
            try
            {
                _repositorio.Criar(usuario);
                return Ok(usuario);
            } catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remover([FromRoute] string id)
        {
            try
            {
                _repositorio.Remover(id);
                return Ok();
            } catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar([FromRoute] string id, [FromBody] Usuario usuario)
        {
            try
            {
                usuario.Id = id;
                _repositorio.Atualizar(usuario);
                return Ok(usuario);
            } catch(Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> ObterPorId([FromRoute] string id)
        {
            try
            {
                var usuario = _repositorio.ObterPorId(id);
                return Ok(usuario);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
