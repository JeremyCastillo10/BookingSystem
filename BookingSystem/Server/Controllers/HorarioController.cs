using BookingSystem.Server.Data;
using BookingSystem.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookingSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HorarioController : ControllerBase
    {
        private readonly Contexto _contexto;

        public HorarioController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<List<Horario>>> GetHorario()
        {
            var horario = await _contexto.Horario.ToListAsync();
            return Ok(horario);
        }
        [HttpGet("{id}")]
        public ActionResult<Horario> GetHorarioPorId(int id)
        {
            var horario = _contexto.Horario.FirstOrDefault(h => h.HorarioId == id);
            return Ok(horario);
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<ActionResult> PostHorario(Horario horario)
        {
            _contexto.Add(horario);
            await _contexto.SaveChangesAsync();
            return Ok(horario);
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteHorario(int id)
        {
            var horario = await _contexto.Horario.FirstOrDefaultAsync(h => h.HorarioId == id);
            if(horario == null)
            {
                return BadRequest(horario);
            }
            _contexto.Remove(horario);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }
    }
}
