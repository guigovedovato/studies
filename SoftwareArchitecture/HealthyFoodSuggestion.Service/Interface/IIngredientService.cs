using HealthyFoodSuggestion.Model.Business;

namespace HealthyFoodSuggestion.Service.Interface
{
    public interface IIngredientService
    {
         Ingredient GetIngredient(string name);
    }
}