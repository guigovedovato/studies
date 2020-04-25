using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;
using HealthyFoodSuggestion.Domain.Dto;
using System.Threading;

namespace HealthyFoodSuggestion.UI.Services
{
    public interface ISuggestionService
    {
         Task<IEnumerable<Recipe>> GetRecipesAsync(
             SuggestionRequest request,
             CancellationToken cancellationToken);
    }
}