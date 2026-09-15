using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblUsuario;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblUsuarioController : ControllerBase
    {
        private readonly ITblUsuarioService _tblUsuarioService;
        public TblUsuarioController(ITblUsuarioService tblUsuarioService)
        {
            _tblUsuarioService = tblUsuarioService;
        }
        [HttpGet("ObtenerUsuarios")]
        public async Task<ActionResult<List<TblUsuarioReadDto>>> ObtenerUsuarios()
        {
            List<TblUsuarioReadDto> usuarios = await _tblUsuarioService.ObtenerTodos();
            return Ok(usuarios);
        }
        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<TblUsuarioReadDto>> ObtenerPorId(int idUsuario)
        {
            TblUsuarioReadDto usuario = await _tblUsuarioService.ObtenerPorId(idUsuario);
            return Ok(usuario);
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idUsuario)
        {
            await _tblUsuarioService.Eliminar(idUsuario);
            return NoContent();
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(TblUsuarioCreateDto usuario)
        {
            await _tblUsuarioService.Crear(usuario);
            return Created();
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(TblUsuarioUpdateDto usuario)
        {
            await _tblUsuarioService.Actualizar(usuario);
            return NoContent();
        }
    }
}
