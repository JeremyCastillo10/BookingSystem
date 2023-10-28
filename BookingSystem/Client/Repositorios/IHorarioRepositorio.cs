using BookingSystem.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BookingSystem.Client.Repositorios
{
    public interface IHorarioRepositorio
    {
        List<Horario> Horarios { get; set; }
        Task<List<Horario>> GetHorario();
        Task<Horario> GetHorarioPorIdAsync(int id);
        Task<bool> DeleteHorario(int id);
        Task CreateHorario(Horario horario);
    }
}
