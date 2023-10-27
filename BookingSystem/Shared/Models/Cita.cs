﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.Shared.Models
{
    public class Cita
    {
        public int CitaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Hora { get; set; }
        public string Duracion { get; set; }
        public bool Estado { get; set; }
        
        public int ProfesionalId { get; set;}
        [ForeignKey("ProfesionalId")]
        public virtual Profesional ?Profesional { get; set; }
        public int ServicioId { get; set; }
        [ForeignKey("ServicioId")]
        public virtual Servicio ?Servicio { get; set; }
    }
}
