using BookingSystem.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Server.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options) { }

        public DbSet<Horario> Horario { get; set; }
        

    }
}
