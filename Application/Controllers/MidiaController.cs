using Dominio.IRepositorios;
using Dominio.Modelos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MidiaController : ControllerBase
    {
        private readonly IMidiaRepositorio _repositorio;
        public MidiaController(IMidiaRepositorio repositorio) {
            _repositorio = repositorio;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Midia>> ObterTodos([FromQuery] string filtro)
        {
            try
            {
                var midias = _repositorio.ObterTodos(filtro);
                return Ok(midias);
            } catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Midia> ObterPorId([FromRoute] string id) 
        { 
            try
            {
                var midia = _repositorio.ObterPorId(id);
                return Ok(midia);
            } catch(Exception)
            {
                return BadRequest();
            } 
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Midia midia)
        {
            try
            {
                _repositorio.Criar(midia);
                return Ok(midia);
            } catch(Exception ) 
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Remover([FromRoute] string id)
        {
            try
            {
                _repositorio.Remover(id);
                return Ok();

            } catch(Exception)
            {
                return BadRequest();
            }
        }
    }
}
