using System.Collections.Generic;
using HealthyFoodSuggestion.Data.Interface;
using HealthyFoodSuggestion.Model.Enum;
using HealthyFoodSuggestion.Service.Interface;
using IngredientModel = HealthyFoodSuggestion.Model.Business.Ingredient;
using RecipeModel = HealthyFoodSuggestion.Model.Business.Recipe;

namespace HealthyFoodSuggestion.Service.Business.Recipe
{
    internal class OmnivoreRecipeService : IRecipeService
    {
        private readonly IRecipeRepository recipeRepository;

        public OmnivoreRecipeService(IRecipeRepository recipeRepository)
        {
            this.recipeRepository = recipeRepository ?? throw new System.ArgumentNullException(nameof(recipeRepository));
        }

        public IEnumerable<RecipeModel> RetrieveRecipes(IngredientModel ingredient)
        {
            return this.recipeRepository.RetrieveRecipes(ingredient, RecipeType.Omnivore);
        }
    }
}