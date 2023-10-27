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

        [HttpPost]
        public async Task<ActionResult<Horario>> PostHorario(Horario horario)
        {
            _contexto.Add(horario);
            await _contexto.SaveChangesAsync();
            return Ok(horario);
        }
    }
}
