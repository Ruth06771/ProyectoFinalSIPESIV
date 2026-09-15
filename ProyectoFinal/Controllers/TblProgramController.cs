using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Negocio.DTOs.TblProgram;
using ProyectoFinal.Negocio.Interfaces;

namespace ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblProgramController : ControllerBase
    {
        private readonly ITblProgramService _tblProgramService;
        public TblProgramController(ITblProgramService tblProgramService)
        {
            _tblProgramService = tblProgramService;
        }
        [HttpGet("ObtenerPrograms")]
        public async Task<ActionResult<List<ReadTblProgramDTO>>> ObtenerPrograms()
        {
            List<ReadTblProgramDTO> programs = await _tblProgramService.ObtenerTodos();
            return Ok(programs);
        }
        [HttpGet("ObtenerPorId")]
        public async Task<ActionResult<ReadTblProgramDTO>> ObtenerPorId(int idProgram)
        {
            ReadTblProgramDTO program = await _tblProgramService.ObtenerPorId(idProgram);
            return Ok(program);
        }
        [HttpDelete("Eliminar")]
        public async Task<ActionResult> Eliminar(int idProgram)
        {
            await _tblProgramService.Eliminar(idProgram);
            return NoContent();
        }
        [HttpPost("Crear")]
        public async Task<ActionResult> Crear(CreateTblProgramDTO program)
        {
            await _tblProgramService.Crear(program);
            return Created();
        }
        [HttpPut("Actualizar")]
        public async Task<ActionResult> Actualizar(UpdateTblProgramDTO program)
        {
            await _tblProgramService.Actualizar(program);
            return NoContent();
        }
    }
}
