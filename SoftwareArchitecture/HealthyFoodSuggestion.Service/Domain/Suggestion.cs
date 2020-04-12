using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Business;
using HealthyFoodSuggestion.Service.Extensions;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Domain
{
    public class Suggestion : ISuggestion
    {
        private readonly IRecipeCreator recipeCreator;
        private readonly IIngredientCreator ingredientCreator;

        public Suggestion(IRecipeCreator recipeCreator, IIngredientCreator ingredientCreator)
        {
            this.recipeCreator = recipeCreator ?? throw new System.ArgumentNullException(nameof(recipeCreator));
            this.ingredientCreator = ingredientCreator ?? throw new System.ArgumentNullException(nameof(ingredientCreator));
        }

        public async Task<IEnumerable<Recipe>> RetrieveSuggestionsAsync(string ingredient, byte type)
        {
            return await recipeCreator
                        .Create(type.MapToModel())
                        .RetrieveRecipesAsync(
                            await ingredientCreator.Create().GetIngredientAsync(ingredient.ToLower())
                        );
        }
    }
}