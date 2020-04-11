using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Model.Dto.Model;

namespace HealthyFoodSuggestion.UI.Services
{
    public interface ISuggestionService
    {
         public Task<IEnumerable<Recipe>> GetRecipesAsync(SuggestionRequest request);
    }
}