using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Business;
using HealthyFoodSuggestion.Domain.Dto;

namespace HealthyFoodSuggestion.UI.Services
{
    public interface ISuggestionService
    {
         public Task<IEnumerable<Recipe>> GetRecipesAsync(SuggestionRequest request);
    }
}