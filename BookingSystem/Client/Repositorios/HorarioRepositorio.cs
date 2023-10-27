using BookingSystem.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BookingSystem.Client.Repositorios
{
    public class HorarioRepositorio : IHorarioRepositorio
    {
        private readonly HttpClient _http;
        public HorarioRepositorio(HttpClient http)
        {

            _http = http;

        }
        public List<Horario> Horarios { get; set; } = new List<Horario>();

        public async Task<List<Horario>> GetHorario()
        {
            return await _http.GetFromJsonAsync<List<Horario>>("api/Horario");
        }


    }
}
