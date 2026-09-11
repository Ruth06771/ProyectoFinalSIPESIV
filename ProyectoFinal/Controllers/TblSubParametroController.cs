using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblSubParametro;
using ProyectoFinal.Negocio.Interfaces;
using ProyectoFinal.Negocio.Services;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblSubParametroController : ControllerBase
    {
        private readonly ITblSubParametroService _tblSubParametroService;
        public TblSubParametroController(ITblSubParametroService tblSubParametroService)
        {
            _tblSubParametroService = tblSubParametroService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblSubParametroDTO subParametro)
        {
            try
            {
                await _tblSubParametroService.Crear(subParametro);
                return StatusCode(201, new { message = "SubParametro creado correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblSubParametroDTO subParametro)
        {
            try
            {
                await _tblSubParametroService.Actualizar(subParametro);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idSubParametro)
        {
            try
            {
                await _tblSubParametroService.Eliminar(idSubParametro);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

    }
}
