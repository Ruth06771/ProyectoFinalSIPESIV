using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblEvento;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblEventoController : ControllerBase
    {
        private readonly ITblEventoService _tblEventoService;

        public TblEventoController(ITblEventoService tblEventoService)
        {
            _tblEventoService = tblEventoService;
        }

        [HttpGet("obtenertodos")]
        public async Task<ActionResult<List<ReadTblEventoDTO>>> ObtenerTodos()
        {
            List<ReadTblEventoDTO> eventos = await _tblEventoService.ObtenerTodos();
            return Ok(eventos);
        }

        [HttpGet("obtenerporid/{idEvento}")]
        public async Task<ActionResult<ReadTblEventoDTO>> ObtenerPorId(int idEvento)
        {
            ReadTblEventoDTO evento = await _tblEventoService.ObtenerPorId(idEvento);
            if (evento == null) return NotFound();
            return Ok(evento);
        }

        [HttpPost("crear")]
        public async Task<ActionResult> Crear(CreateTblEventoDTO evento)
        {
            await _tblEventoService.Crear(evento);
            return Created();
        }

        [HttpPut("actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblEventoDTO evento)
        {
            await _tblEventoService.Actualizar(evento);
            return NoContent();
        }

        [HttpDelete("eliminar/{idEvento}")]
        public async Task<ActionResult> Eliminar(int idEvento)
        {
            await _tblEventoService.Eliminar(idEvento);
            return NoContent();
        }
    }
}
