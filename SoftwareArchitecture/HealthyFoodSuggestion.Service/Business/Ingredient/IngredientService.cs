using HealthyFoodSuggestion.Data.Interface;
using IngredientModel = HealthyFoodSuggestion.Domain.Model.Ingredient;
using HealthyFoodSuggestion.Service.Interface;
using System.Threading.Tasks;

namespace HealthyFoodSuggestion.Service.Business.Ingredient
{
    internal class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository ?? throw new System.ArgumentNullException(nameof(ingredientRepository));
        }

        public async Task<IngredientModel> GetIngredientAsync(string name)
        {
            return await this.ingredientRepository.GetIngredientAsync(name);
        }
    }
}