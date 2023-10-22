using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.Server.Models
{
    public class Servicio
    {
        public int ServicioId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public double Precio { get; set; }
        public virtual Profesional ?Profesional { get; set;}
        public virtual List<Profesional> Profesionales { get; set; } = new List<Profesional>();
    }
}
