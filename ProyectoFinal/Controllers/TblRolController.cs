using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblRol;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblRolController : ControllerBase
    {
        private readonly ITblRolService _tblRolService;
        public TblRolController(ITblRolService tblRolService)
        {
            _tblRolService = tblRolService;
        }
        [HttpGet("ObtenerRoles")]
        public async Task<ActionResult<List<ReadTblRolDTO>>> ObtenerRoles()
        {
            List<ReadTblRolDTO> roles = await _tblRolService.ObtenerTodos();
            return Ok(roles);
        }
        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<ReadTblRolDTO>> ObtenerPorId(int idRol)
        {
            ReadTblRolDTO rol = await _tblRolService.ObtenerPorId(idRol);
            return Ok(rol);
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idRol)
        {
            await _tblRolService.Eliminar(idRol);
            return NoContent();
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblRolDTO rol)
        {
            await _tblRolService.Crear(rol);
            return Created();
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblRolDTO rol)
        {
            await _tblRolService.Actualizar(rol);
            return NoContent();
        }
    }
}
