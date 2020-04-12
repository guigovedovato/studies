using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Business;
using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Data.Interface
{
    public interface IRecipeRepository
    {
         Task<IEnumerable<Recipe>> RetrieveRecipesAsync(Ingredient ingredient, RecipeType type);
    }
}