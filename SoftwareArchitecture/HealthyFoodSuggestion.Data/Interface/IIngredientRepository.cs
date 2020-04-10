using HealthyFoodSuggestion.Model.Business;

namespace HealthyFoodSuggestion.Data.Interface
{
    public interface IIngredientRepository
    {
         Ingredient GetIngredient(string name);
    }
}