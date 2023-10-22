using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Server.Models
{
    public class Horario
    {
        [Key]
        public int HorarioId { get; set; }
        public string Dia { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
    }
}
