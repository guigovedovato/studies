using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Business;
using HealthyFoodSuggestion.Service.Extensions;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Domain
{
    public class Suggestion : ISuggestion
    {
        private readonly IRecipeFactory recipeFactory;
        private readonly IIngredientFactory ingredientFactory;

        public Suggestion(IRecipeFactory recipeCreator, IIngredientFactory ingredientCreator)
        {
            this.recipeFactory = recipeCreator ?? throw new System.ArgumentNullException(nameof(recipeCreator));
            this.ingredientFactory = ingredientCreator ?? throw new System.ArgumentNullException(nameof(ingredientCreator));
        }

        public async Task<IEnumerable<Recipe>> RetrieveSuggestionsAsync(string ingredient, byte type)
        {
            return await recipeFactory
                        .Create(type.MapToModel())
                        .RetrieveRecipesAsync(
                            await ingredientFactory.Create().GetIngredientAsync(ingredient.ToLower())
                        );
        }
    }
}