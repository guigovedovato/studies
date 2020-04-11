using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Model.Business;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface IRecipeService
    {
         Task<IEnumerable<Recipe>> RetrieveRecipesAsync(Ingredient ingredient);
    }
}