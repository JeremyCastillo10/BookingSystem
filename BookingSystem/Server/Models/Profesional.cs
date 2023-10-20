using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.Server.Models
{
    public class Profesional
    {
        [Key]
        public int ProfesionalId { get; set; }

        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public string Especialidad { get; set; }

        public int ServicioId { get; set; }
        [ForeignKey("ServicioId")]
        public virtual Servicio? Servicio { get; set; }

        public int HorarioId { get; set; }
        [ForeignKey("HorarioId")]
        public virtual Horario ?Horario { get; set; }


    }

}
