using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Domain.Enum;
using HealthyFoodSuggestion.Service.Interface;
using IngredientModel = HealthyFoodSuggestion.Domain.Business.Ingredient;
using RecipeModel = HealthyFoodSuggestion.Domain.Business.Recipe;

namespace HealthyFoodSuggestion.Service.Business.Recipe
{
    internal class OmnivoreRecipeService : IRecipeService
    {
        private readonly IRecipeRepository recipeRepository;

        public OmnivoreRecipeService(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository ?? throw new System.ArgumentNullException(nameof(recipeRepository));
        }

        public async Task<IEnumerable<RecipeModel>> RetrieveRecipesAsync(IngredientModel ingredient)
        {
            return await this.recipeRepository.RetrieveRecipesAsync(ingredient, RecipeType.Omnivore);
        }
    }
}