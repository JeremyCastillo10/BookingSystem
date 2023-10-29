using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.Shared.Models
{
    public class Profesional
    {
        [Key]
        public int ProfesionalId { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string Especialidad { get; set; }
        public bool Estado { get; set; }
        public bool Visible { get; set; } = true;

    }

}
