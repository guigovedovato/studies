using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Enum;
using HealthyFoodSuggestion.Domain.Model;

namespace HealthyFoodSuggestion.Data.Interface
{
    public interface IRecipeRepository
    {
         Task<IEnumerable<Recipe>> RetrieveRecipesAsync(Ingredient ingredient, RecipeType type);
    }
}