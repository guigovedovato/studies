using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;
using HealthyFoodSuggestion.Domain.Dto;

namespace HealthyFoodSuggestion.UI.Services
{
    public interface ISuggestionService
    {
         Task<IEnumerable<Recipe>> GetRecipesAsync(SuggestionRequest request);
    }
}