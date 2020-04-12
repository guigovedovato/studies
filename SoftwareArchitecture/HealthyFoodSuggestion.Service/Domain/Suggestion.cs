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

        public Suggestion(IRecipeFactory recipeFactory, IIngredientFactory ingredientFactory)
        {
            this.recipeFactory = recipeFactory ?? throw new System.ArgumentNullException(nameof(recipeFactory));
            this.ingredientFactory = ingredientFactory ?? throw new System.ArgumentNullException(nameof(ingredientFactory));
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