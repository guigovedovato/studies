using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Model.Enum;
using HealthyFoodSuggestion.Service.Interface;
using IngredientModel = HealthyFoodSuggestion.Model.Business.Ingredient;
using RecipeModel = HealthyFoodSuggestion.Model.Business.Recipe;

namespace HealthyFoodSuggestion.Service.Business.Recipe
{
    internal class VegetarianRecipeService : IRecipeService
    {
        private readonly IRecipeRepository recipeRepository;

        public VegetarianRecipeService(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository ?? throw new System.ArgumentNullException(nameof(recipeRepository));
        }

        public async Task<IEnumerable<RecipeModel>> RetrieveRecipesAsync(IngredientModel ingredient)
        {
            return await this.recipeRepository.RetrieveRecipesAsync(ingredient, RecipeType.Vegetarian);
        }
    }
}