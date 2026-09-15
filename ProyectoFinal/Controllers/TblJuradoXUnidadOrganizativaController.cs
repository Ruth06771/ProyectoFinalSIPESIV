using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblJuradoXUnidadOrganzativa;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblJuradoXUnidadOrganizativaController : ControllerBase
    {
        private readonly ITblJuradoXUnidadOrganizativaService _tblJuradoXUnidadOrganizativaService;

        public TblJuradoXUnidadOrganizativaController(ITblJuradoXUnidadOrganizativaService tblJuradoXUnidadOrganizativaService)
        {
            _tblJuradoXUnidadOrganizativaService = tblJuradoXUnidadOrganizativaService;
        }

        [HttpGet("obtenertodos")]
        public async Task<ActionResult<List<ReadTblJuradoXUnidadOrganzativaDTO>>> ObtenerTodos()
        {
            List<ReadTblJuradoXUnidadOrganzativaDTO> jurados = await _tblJuradoXUnidadOrganizativaService.ObtenerTodos();
            return Ok(jurados);
        }

        [HttpGet("obtenerporid/{idJuradoXFacultad}")]
        public async Task<ActionResult<ReadTblJuradoXUnidadOrganzativaDTO>> ObtenerPorId(int idJuradoXFacultad)
        {
            ReadTblJuradoXUnidadOrganzativaDTO jurado = await _tblJuradoXUnidadOrganizativaService.ObtenerPorId(idJuradoXFacultad);
            if (jurado == null) return NotFound();
            return Ok(jurado);
        }

        [HttpPost("crear")]
        public async Task<ActionResult> Crear(CreateTblJuradoXUnidadOrganzativaDTO jurado)
        {
            await _tblJuradoXUnidadOrganizativaService.Crear(jurado);
            return Created();
        }

        [HttpPut("actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblJuradoXUnidadOrganzativaDTO jurado)
        {
            await _tblJuradoXUnidadOrganizativaService.Actualizar(jurado);
            return NoContent();
        }

        [HttpDelete("eliminar/{idJuradoXFacultad}")]
        public async Task<ActionResult> Eliminar(int idJuradoXFacultad)
        {
            await _tblJuradoXUnidadOrganizativaService.Eliminar(idJuradoXFacultad);
            return NoContent();
        }
    }
}