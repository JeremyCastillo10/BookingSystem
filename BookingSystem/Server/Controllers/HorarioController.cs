using BookingSystem.Server.Data;
using BookingSystem.Server.Models;
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
        public async Task<IActionResult> Get()
        {
            return Ok(await _contexto.Horario.ToListAsync());
        }
    }
}
