﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.Shared.Models
{
    public class Cita
    {
        [Key]
        public int CitaId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Hora { get; set; }
        public string Duracion { get; set; }
        public bool Estado { get; set; }
        public int ClienteId { get; set; }

        public int ProfesionalId { get; set;}
        public int ServicioId { get; set; }

        public bool Visible { get; set; } = true;
    }
}
