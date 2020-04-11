using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Model.Dto.Model;
using System.Text.Json;

namespace HealthyFoodSuggestion.UI.Services
{
    public class SuggestionService : ISuggestionService
    {
        private readonly HttpClient httpClient;

        public SuggestionService(HttpClient httpClient)
        {
            this.httpClient = httpClient ?? throw new System.ArgumentNullException(nameof(httpClient));
        }

        public async Task<IEnumerable<Recipe>> GetRecipesAsync(SuggestionRequest request)
        {
            var response = await httpClient.GetStringAsync($"v1/suggestion/{request.Type}/{request.ingredient}");
            return JsonSerializer.Deserialize<IEnumerable<Recipe>>(response);
        }
    }
}