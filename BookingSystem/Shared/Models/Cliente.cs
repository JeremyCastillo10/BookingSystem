namespace BookingSystem.Shared.Models
{
    public class Cliente
    { 
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Visible { get; set; } = true;
    }
}
