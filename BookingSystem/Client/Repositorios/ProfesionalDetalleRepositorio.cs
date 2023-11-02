using BookingSystem.Shared.Models;

namespace BookingSystem.Client.Repositorios
{
    public class ProfesionalDetalleRepositorio : IProfesionalDetalleRepositorio
    {
        private readonly HttpClient _http;
        public ProfesionalDetalleRepositorio(HttpClient httpClient)
        {
            _http = httpClient;
        }
        public async Task CreateProfesionalDetalle(ProfesionalDetalle profesionalDetalle)
        {
            var response = await _http.PostAsJsonAsync("api/ProfesionalDetalle/Guardar", profesionalDetalle);
            
        }

        public async Task<List<ProfesionalDetalle>> GetProfesionalDetalles()
        {
            return await _http.GetFromJsonAsync<List<ProfesionalDetalle>>("api/ProfesionalDetalle");
            
        }
    }
}
