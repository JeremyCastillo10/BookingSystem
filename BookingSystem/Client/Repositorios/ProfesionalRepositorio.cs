using BookingSystem.Shared.Models;

namespace BookingSystem.Client.Repositorios
{
    public class ProfesionalRepositorio : IProfesionalRepositorio
    {
        private readonly HttpClient _http;
        public ProfesionalRepositorio(HttpClient httpClient)
        {
            _http = httpClient;
            
        }

        public async Task CreateProfesional(Profesional profesional)
        {
            var response = _http.PostAsJsonAsync("api/Profesional/Guardar", profesional);
        }

        public async Task<List<Profesional>> GetProfesional()
        {
            return await _http.GetFromJsonAsync<List<Profesional>>("api/Profesional");
        }
    }
}
