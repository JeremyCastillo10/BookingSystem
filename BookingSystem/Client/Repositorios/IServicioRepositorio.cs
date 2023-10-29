using BookingSystem.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BookingSystem.Client.Repositorios
{
    public interface IServicioRepositorio
    {
        List<Servicio> Servicio{ get; set; }
        Task<List<Servicio>> GetServicio();
        Task<Servicio> GetServicioPorIdAsync(int id);
        Task<bool> DeleteServicio(int id);
        Task CreateServicio(Servicio servicio);
    }
}
