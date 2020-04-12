using HealthyFoodSuggestion.Domain.Enum;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface IRecipeFactory
    {
         IRecipeService Create(RecipeType type);
    }
}