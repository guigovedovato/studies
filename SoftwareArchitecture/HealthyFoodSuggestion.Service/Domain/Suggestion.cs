using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Model;
using HealthyFoodSuggestion.Domain.Parameters;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Domain
{
    public class Suggestion : ISuggestion
    {
        private readonly IRecipeFactory recipeFactory;
        private readonly IIngredientFactory ingredientFactory;

        public Suggestion(IRecipeFactory recipeFactory, IIngredientFactory ingredientFactory)
        {
            this.recipeFactory = recipeFactory ?? 
                throw new System.ArgumentNullException(nameof(recipeFactory));
            this.ingredientFactory = ingredientFactory ?? 
                throw new System.ArgumentNullException(nameof(ingredientFactory));
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync(SuggestionParameters suggestionParameters)
        => await recipeFactory
                    .Create(suggestionParameters.Type)
                    .RetrieveRecipesAsync(await CreateIngredient(suggestionParameters.Ingredient));

        private async Task<Ingredient> CreateIngredient(string ingredient)
        {
            Ingredient ingredientModel = null;

            if (!string.IsNullOrWhiteSpace(ingredient))
            {
                ingredientModel = await ingredientFactory
                                         .Create()
                                         .GetIngredientAsync(ingredient.ToLower());
            }

            return ingredientModel;
        }
    }
}