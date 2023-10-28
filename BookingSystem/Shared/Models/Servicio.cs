using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.Shared.Models
{
    public class Servicio
    {
        [Key]
        public int ServicioId { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(2, ErrorMessage = "Al menos {1} caractéres.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(2, ErrorMessage = "Al menos {1} caractéres.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(2, ErrorMessage = "Al menos {1} caractéres.")]
        public string Duracion { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(2, ErrorMessage = "Al menos {1} caractéres.")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [MinLength(2, ErrorMessage = "Al menos {1} caractéres.")]
        public int ProfesionalId { get; set; }
        public bool Visible { get; set; } = true;
    }
}
