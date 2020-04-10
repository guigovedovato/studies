using System.Collections.Generic;
using HealthyFoodSuggestion.Model.Business;
using HealthyFoodSuggestion.Service.Extensions;
using HealthyFoodSuggestion.Service.Interface;

namespace HealthyFoodSuggestion.Service.Command
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

        public IEnumerable<Recipe> RetrieveSuggestions(string ingredient, byte type)
        {
            return recipeCreator
                        .Create(type.MapToModel())
                        .RetrieveRecipes(
                            ingredientCreator.Create().GetIngredient(ingredient.ToLower())
                        );
        }
    }
}