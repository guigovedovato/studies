using System.Threading;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;
using System.Text.Json;
using HealthyFoodSuggestion.Domain.Parameters;

namespace HealthyFoodSuggestion.UI.Services
{
    internal class SuggestionService : ISuggestionService
    {
        private readonly HttpClient httpClient;

        public SuggestionService(HttpClient httpClient) 
            => this.httpClient = 
                httpClient ?? 
                throw new System.ArgumentNullException(nameof(httpClient));

        public async Task<IEnumerable<Recipe>> GetRecipesAsync(
            SuggestionParameters parameters,
            CancellationToken cancellationToken)
        {
            var response = await httpClient.GetAsync($"api/v1/suggestions?type={parameters.Type}&ingredient={parameters.Ingredient}",
                cancellationToken);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            
            return JsonSerializer.Deserialize<IEnumerable<Recipe>>(content);
        }
    }
}