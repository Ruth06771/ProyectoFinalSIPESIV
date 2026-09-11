using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblPersona;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblPersonaController : ControllerBase
    {
        private readonly ITblPersonaService _tblPersonaService;
        public TblPersonaController(ITblPersonaService tblPersonaService)
        {
            _tblPersonaService = tblPersonaService;
        }
        [HttpGet("ObtenerPersonas")]
        public async Task<ActionResult<List<ReadTblPersonaDTO>>> ObtenerPersonas()
        {
            List<ReadTblPersonaDTO> personas = await _tblPersonaService.ObtenerTodos();
            return Ok(personas);
        }
        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<ReadTblPersonaDTO>> ObtenerPorId(int idPersona)
        {
            ReadTblPersonaDTO persona = await _tblPersonaService.ObtenerPorId(idPersona);
            return Ok(persona);
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idPersona)
        {
            await _tblPersonaService.Eliminar(idPersona);
            return NoContent();
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblPersonaDTO persona)
        {
            await _tblPersonaService.Crear(persona);
            return Created();
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblPersonaDTO persona)
        {
            await _tblPersonaService.Actualizar(persona);
            return NoContent();
        }
    }
}
