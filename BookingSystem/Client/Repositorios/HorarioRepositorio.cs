using Azure;
using BookingSystem.Shared.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Text.Json.Serialization;
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

        public List<Horario> Horarios { get; set ; }

        public async Task CreateHorario(Horario horario)
        {
            var response = await _http.PostAsJsonAsync("api/Horario/Guardar", horario);      
            

        }

        public async Task<bool> DeleteHorario(int id)
        {

                var response = await _http.DeleteAsync($"api/Horario/{id}"); // Ajusta la URL según tu API.
                return response.IsSuccessStatusCode;

        }





        public async Task<List<Horario>> GetHorario()
        {
            return await _http.GetFromJsonAsync<List<Horario>>("api/Horario");

        }
       

        public async Task<Horario> GetHorarioPorIdAsync(int id)
        {
            var response = await _http.GetAsync($"api/Horario/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var horario = JsonConvert.DeserializeObject<Horario>(content);
                return horario;
            }
            return null;
        }
    }
}
