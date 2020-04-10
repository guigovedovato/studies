using HealthyFoodSuggestion.Data.Interface;
using IngredientModel = HealthyFoodSuggestion.Model.Business.Ingredient;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Business.Ingredient
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository ?? throw new System.ArgumentNullException(nameof(ingredientRepository));
        }

        public IngredientModel GetIngredient(string name)
        {
            return this.ingredientRepository.GetIngredient(name);
        }
    }
}