using System.Collections.Generic;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Model.Enum;

namespace HealthyFoodSuggestion.Data.Interface
{
    public interface IRecipeRepository
    {
         IEnumerable<Recipe> RetrieveRecipes(Ingredient ingredient, RecipeType type);
    }
}