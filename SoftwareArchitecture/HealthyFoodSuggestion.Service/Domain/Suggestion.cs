using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HealthyFoodSuggestion.Domain.Enum;
using HealthyFoodSuggestion.Domain.Model;
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

        public Task<IEnumerable<Recipe>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Recipe> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Recipe>> RetrieveSuggestionsAsync(string ingredient, RecipeType type)
            =>  await recipeFactory
                        .Create(type)
                        .RetrieveRecipesAsync(
                            await ingredientFactory.Create().GetIngredientAsync(ingredient.ToLower())
                        );
    }
}