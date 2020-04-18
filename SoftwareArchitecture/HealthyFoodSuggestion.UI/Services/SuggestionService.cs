using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;
using System.Text.Json;
using HealthyFoodSuggestion.Domain.Dto;

namespace HealthyFoodSuggestion.UI.Services
{
    internal class SuggestionService : ISuggestionService
    {
        private readonly HttpClient httpClient;

        public SuggestionService(HttpClient httpClient) 
            => this.httpClient = 
                httpClient ?? 
                throw new System.ArgumentNullException(nameof(httpClient));

        public async Task<IEnumerable<Recipe>> GetRecipesAsync(SuggestionRequest request)
        {
            var response = await httpClient.GetStringAsync($"v1/suggestion/{request.Type}/{request.Ingredient}");
            return JsonSerializer.Deserialize<IEnumerable<Recipe>>(response);
        }
    }
}