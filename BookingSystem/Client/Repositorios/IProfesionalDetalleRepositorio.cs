using BookingSystem.Shared.Models;

namespace BookingSystem.Client.Repositorios
{
    public interface IProfesionalDetalleRepositorio
    {
        Task<List<ProfesionalDetalle>> GetProfesionalDetalles();
        Task CreateProfesionalDetalle(ProfesionalDetalle profesionalDetalle);
    }
}
