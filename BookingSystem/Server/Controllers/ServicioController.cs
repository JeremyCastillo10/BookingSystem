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

    public class ServicioController : ControllerBase
    {
        private readonly Contexto _contexto;

        public ServicioController(Contexto contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<List<Servicio>>> GetServicio()
        {
            var servicio = await _contexto.Servicio.ToListAsync();
            return Ok(servicio);
        }
        [HttpGet("{id}")]
        public ActionResult<Servicio> GetServicioPorId(int id)
        {
            var servicio = _contexto.Servicio.FirstOrDefault(h => h.ServicioId == id);
            return Ok(servicio);
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<ActionResult> PostServicio(Servicio servicio)
        {
            _contexto.Add(servicio);
            await _contexto.SaveChangesAsync();
            return Ok(servicio);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteServicio(int id)
        {
            var dbservicio = await _contexto.Servicio.FindAsync(id);
            if (dbservicio == null)
            {
                return NotFound(); // Devuelve un 404 Not Found si el registro no existe.
            }

            // Marcar el campo "Visible" como false.
            dbservicio.Visible = false;

            await _contexto.SaveChangesAsync();

            return Ok(true); 
        }

    }
}
