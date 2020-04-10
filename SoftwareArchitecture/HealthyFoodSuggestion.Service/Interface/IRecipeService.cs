using System.Collections.Generic;
using HealthyFoodSuggestion.Model.Business;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface IRecipeService
    {
         IEnumerable<Recipe> RetrieveRecipes(Ingredient ingredient);
    }
}