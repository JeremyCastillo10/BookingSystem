using BookingSystem.Shared.Models;

namespace BookingSystem.Client.Repositorios
{
    public interface IHorarioRepositorio
    {
        List<Horario> Horarios {get; set;}
        Task<List<Horario>> GetHorario();
    }
}
