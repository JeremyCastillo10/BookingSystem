using BookingSystem.Shared.Models;

namespace BookingSystem.Client.Repositorios
{
    public interface IProfesionalRepositorio
    {
        Task<List<Profesional>> GetProfesional();
        Task CreateProfesional(Profesional profesional);
    }
}
