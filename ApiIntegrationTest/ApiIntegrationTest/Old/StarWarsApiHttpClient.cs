using ApiIntegrationTest.Api.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Old
{
    internal class StarWarsApiHttpClient
    {
        private readonly HttpClient httpClient;

        public StarWarsApiHttpClient()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://swapi.dev/api/");
        }

        public async Task<SwApiCharacterResponse> GetCharacterByIdAsync(int characterId)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"people/{characterId}/");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                SwApiCharacterResponse character = JsonSerializer.Deserialize<SwApiCharacterResponse>(json);
                return character;
            }
            else
            {
                return null;
            }
        }
    }
}
