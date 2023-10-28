using System.ComponentModel.DataAnnotations;

namespace BookingSystem.Shared.Models
{
    public class Horario
    {
        [Key]
        
        public int HorarioId { get; set; }
        public string Dia { get; set; } = string.Empty;
        public string HoraInicio { get; set; } = string.Empty;
        public string HoraFin { get; set; } = string.Empty;
        public bool Visible { get; set; } = true;
    }
}
