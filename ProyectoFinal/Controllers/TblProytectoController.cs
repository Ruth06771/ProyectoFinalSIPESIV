using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblProyecto;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblProyectoController : ControllerBase
    {
        private readonly ITblProyectoService _tblProyectoService;

        public TblProyectoController(ITblProyectoService tblProyectoService)
        {
            _tblProyectoService = tblProyectoService;
        }

        [HttpGet("obtenertodos")]
        public async Task<ActionResult<List<ReadTblProyectoDTO>>> ObtenerTodos()
        {
            List<ReadTblProyectoDTO> proyectos = await _tblProyectoService.ObtenerTodos();
            return Ok(proyectos);
        }

        [HttpGet("obtenerporid/{idProyecto}")]
        public async Task<ActionResult<ReadTblProyectoDTO>> ObtenerPorId(int idProyecto)
        {
            ReadTblProyectoDTO proyecto = await _tblProyectoService.ObtenerPorId(idProyecto);
            if (proyecto == null) return NotFound();
            return Ok(proyecto);
        }

        [HttpPost("crear")]
        public async Task<ActionResult> Crear(CreateTblProyectoDTO proyecto)
        {
            await _tblProyectoService.Crear(proyecto);
            return Created();
        }

        [HttpPut("actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblProyectoDTO proyecto)
        {
            await _tblProyectoService.Actualizar(proyecto);
            return NoContent();
        }

        [HttpDelete("eliminar/{idProyecto}")]
        public async Task<ActionResult> Eliminar(int idProyecto)
        {
            await _tblProyectoService.Eliminar(idProyecto);
            return NoContent();
        }
    }
}