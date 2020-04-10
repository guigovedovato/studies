using HealthyFoodSuggestion.Model.Enum;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface IRecipeCreator
    {
         IRecipeService Create(RecipeType type);
    }
}