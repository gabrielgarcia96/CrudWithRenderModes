using CrudWithRenderModes.Shared.Entities;
using CrudWithRenderModes.Shared.Interfaces;
using System.Net.Http.Json;
using System.Reflection;
using System.Text.Json;

namespace CrudWtithRenderModes.Client.Services
{
    public class SetoresService : ISetoresRepository
    {
        private readonly HttpClient httpClient;
        private readonly JsonSerializerOptions _options;

        public SetoresService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<Setores> AddSetoresAsync(Setores model)
        {
            var setor = await httpClient.PostAsJsonAsync("api/Setores/Add-Setores", model);
            var response = await setor.Content.ReadFromJsonAsync<Setores>();
            return response!;
        }

        public async Task<Setores> DeleteSetoresAsync(int setoresId)
        {
            var setor = await httpClient.DeleteAsync($"api/Setores/Delete-Setores/{setoresId}");
            var response = await setor.Content.ReadFromJsonAsync<Setores>();
            return response!;
        }

        public async Task<List<Setores>> GetAllSetoresAsync()
        {
            var setor = await httpClient.GetAsync("api/Setores/Setores");
            var response = await setor.Content.ReadFromJsonAsync<List<Setores>>();
            return response!;
        }

        public async Task<Setores> GetSetoresByIdAsync(int setoresId)
        {
            var setor = await httpClient.GetAsync($"api/Setores/Setores/{setoresId}");
            var response = await setor.Content.ReadFromJsonAsync<Setores>();
            return response!;
        }

        public async Task<Setores> UpdateSetoresAsync(Setores model)
        {
            var setor = await httpClient.PutAsJsonAsync("api/Setores/Update-Setores", model);
            var response = await setor.Content.ReadFromJsonAsync<Setores>();
            return response!;
        }
    }
}
