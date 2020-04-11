using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Model.Enum;

namespace HealthyFoodSuggestion.Data.Interface
{
    public interface IRecipeRepository
    {
         Task<IEnumerable<Recipe>> RetrieveRecipesAsync(Ingredient ingredient, RecipeType type);
    }
}