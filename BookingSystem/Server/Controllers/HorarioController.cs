using BookingSystem.Server.Data;
using BookingSystem.Shared;
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

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteHorario(int id)
        {
            var dbhorario = await _contexto.Horario.FindAsync(id);
            if (dbhorario == null)
            {
                return NotFound(); // Devuelve un 404 Not Found si el registro no existe.
            }

            // Marcar el campo "Visible" como false.
            dbhorario.Visible = false;

            await _contexto.SaveChangesAsync();

            return Ok(true); 
        }

    }
}
