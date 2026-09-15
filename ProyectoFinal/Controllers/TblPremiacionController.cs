using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblPremiacion;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPremiacionController : ControllerBase
    {
        private readonly ITblPremiacionService _tblPremiacionService;

        public TblPremiacionController(ITblPremiacionService tblPremiacionService)
        {
            _tblPremiacionService = tblPremiacionService;
        }

        [HttpGet("obtenertodos")]
        public async Task<ActionResult<List<ReadTblPremiacionDTO>>> ObtenerTodos()
        {
            List<ReadTblPremiacionDTO> premiaciones = await _tblPremiacionService.ObtenerTodos();
            return Ok(premiaciones);
        }

        [HttpGet("obtenerporid/{idPremiacion}")]
        public async Task<ActionResult<ReadTblPremiacionDTO>> ObtenerPorId(int idPremiacion)
        {
            ReadTblPremiacionDTO premiacion = await _tblPremiacionService.ObtenerPorId(idPremiacion);
            if (premiacion == null) return NotFound();
            return Ok(premiacion);
        }

        [HttpPost("crear")]
        public async Task<ActionResult> Crear(CreateTblPremiacionDTO premiacion)
        {
            await _tblPremiacionService.Crear(premiacion);
            return Created();
        }

        [HttpPut("actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblPremiacionDTO premiacion)
        {
            await _tblPremiacionService.Actualizar(premiacion);
            return NoContent();
        }

        [HttpDelete("eliminar/{idPremiacion}")]
        public async Task<ActionResult> Eliminar(int idPremiacion)
        {
            await _tblPremiacionService.Eliminar(idPremiacion);
            return NoContent();
        }
    }
}

