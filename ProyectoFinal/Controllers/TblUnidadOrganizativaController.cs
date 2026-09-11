using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblUnidadOrganizativa;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblUnidadOrganizativaController : ControllerBase
    {
        private readonly ITblUnidadOrganizativaService _tblUnidadOrganizativaService;
        public TblUnidadOrganizativaController(ITblUnidadOrganizativaService tblUnidadOrganizativaService)
        {
            _tblUnidadOrganizativaService = tblUnidadOrganizativaService;
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblUnidadOrganizativaDTO unidadOrganizativa)
        {
            try
            {
                await _tblUnidadOrganizativaService.Crear(unidadOrganizativa);
                return StatusCode(201, new { message = "Unidad Organizativa creada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblUnidadOrganizativaDTO unidadOrganizativa)
        {
            try
            {
                await _tblUnidadOrganizativaService.Actualizar(unidadOrganizativa);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idUnidadOrganizativa)
        {
            try
            {
                await _tblUnidadOrganizativaService.Eliminar(idUnidadOrganizativa);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }
}
