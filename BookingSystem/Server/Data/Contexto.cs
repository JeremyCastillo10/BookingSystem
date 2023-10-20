using Microsoft.EntityFrameworkCore;

namespace BookingSystem.Server.Data
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options) { }
        
    }
}
